using System;
using System.Linq;
using System.Linq.Expressions;

namespace KimNhanShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Generic Method, có thể sử dụng cho tất cả các lớp trong dự án: add, Update ...
        // Định nghĩa ra các phương thức
        // Marks an entity as new
        void Add(T entity);

        // Marks an entity as modified
        void Update(T entity);

        // Marks an entity to be removed
        void Delete(T entity);

        // Delete Multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Get an entity by int id
        T GetSingleById(int id);

        // Get an entity by condition, thêm include bảng con
        // include là 1 mảng string giúp include các thuộc tính liên quan giống như include 1 connection
        // Ví dụ: select ra 1 bài viết thì include thêm thuộc tính category thì sẽ lấy được các bản ghi theo category
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] include = null);

        // Lấy tất theo include
        IQueryable<T> GetAll(string[] includes = null);

        // Tìm Kiếm
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        // Lấy Paging Sau khi Order by
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] include = null);

        // Đếm bản ghi theo điều kiện
        int Count(Expression<Func<T, bool>> where);

        // Check Bản ghi tồn tại hay không theo điều kiện
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}