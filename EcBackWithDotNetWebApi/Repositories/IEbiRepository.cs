using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcBackWithDotNetWebApi.Repositories
{
    public interface IEbiRepository<ModelType>
    {
        /// <summary>
        /// 取得処理
        /// </summary>
        /// <param name="id">取得キー</param>
        /// <returns>取得結果</returns>
        ModelType Get(int id);

        /// <summary>
        /// 一覧取得処理
        /// </summary>
        /// <returns>取得結果</returns>
        IQueryable<ModelType> GetAll();

        /// <summary>
        /// 新規登録処理
        /// </summary>
        /// <param name="entity">登録データ</param>
        /// <returns>登録データ</returns>
        ModelType Insert(ModelType entity);

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="originalEntity">更新前データ</param>
        /// <param name="updatedEntity">更新データ</param>
        /// <returns>更新データ</returns>
        ModelType Update(ModelType originalEntity, ModelType updatedEntity);

        /// <summary>
        /// 更新処理
        /// </summary>
        /// <param name="id">更新対象のid</param>
        /// <param name="updatedEntity">更新データ</param>
        /// <returns>更新データ</returns>
        ModelType Update(int id, ModelType updatedEntity);

        /// <summary>
        /// 削除処理
        /// </summary>
        /// <param name="entity">削除データ</param>
        /// <returns>削除データ</returns>
        ModelType Delete(ModelType entity);

        /// <summary>
        /// 削除処理
        /// </summary>
        /// <param name="id">削除対象のid</param>
        /// <returns>削除データ</returns>
        ModelType Delete(int id);

        /// <summary>
        /// 保存処理
        /// </summary>
        /// <returns>保存件数</returns>
        int SaveAll();
    }
}
