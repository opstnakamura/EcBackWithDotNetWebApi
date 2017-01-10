using EcBackWithDotNetWebApi.DbContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcBackWithDotNetWebApi.Repositories
{
    public class EbiRepository<TEntity> : IEbiRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// DBコンテキスト
        /// </summary>
        private EbiDB _ctx;

        public EbiRepository()
        {
            _ctx = new EbiDB();

            //ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //_ctx.Database.Log = x => { Logger.Debug("db_log:" + x.TrimEnd('\r', '\n')); };
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ctx">DBコンテキスト</param>
        public EbiRepository(EbiDB ctx)
        {
            _ctx = ctx;

            //ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //_ctx.Database.Log = x => { Logger.Debug("db_log:" + x.TrimEnd('\r', '\n')); };
        }


        /// <summary>
        /// 取得処理
        /// </summary>
        /// <param name="id">主キー</param>
        /// <returns>取得結果</returns>
        public TEntity Get(int id)
        {

            return this._ctx.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// 一覧取得
        /// </summary>
        /// <returns>取得結果</returns>
        public IQueryable<TEntity> GetAll()
        {
            return this._ctx.Set<TEntity>().AsQueryable();
        }

        /// <summary>
        /// 新規登録処理
        /// </summary>
        /// <param name="entity">登録データ</param>
        /// <returns>登録データ</returns>
        public TEntity Insert(TEntity entity)
        {

            return this._ctx.Set<TEntity>().Add(entity);
        }

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="original">更新前データ</param>
        /// <param name="updated">更新データ</param>
        /// <returns>更新データ</returns>
        public TEntity Update(TEntity original, TEntity updated)
        {

            this._ctx.Entry(original).CurrentValues.SetValues(updated);
            return original;
        }


        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="id">更新対象のid</param>
        /// <param name="updated">更新データ</param>
        /// <returns>更新データ</returns>
        public TEntity Update(int id, TEntity updated)
        {
            TEntity original = this._ctx.Set<TEntity>().Find(id);

            if (original == null)
            {
                return null;
            }

            return Update(original, updated);
        }


        /// <summary>
        /// 削除処理
        /// </summary>
        /// <param name="entity">削除データ</param>
        /// <returns>削除データ</returns>
        public TEntity Delete(TEntity entity)
        {
            return this._ctx.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// 削除処理
        /// </summary>
        /// <param name="id">削除対象のid</param>
        /// <returns>削除データ</returns>
        public TEntity Delete(int id)
        {
            TEntity entity = this._ctx.Set<TEntity>().Find(id);

            if (entity == null)
            {
                return null;
            }
            return this._ctx.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// 保存処理
        /// </summary>
        /// <returns>保存件数</returns>
        public int SaveAll()
        {
            return this._ctx.SaveChanges();
        }
    }
}