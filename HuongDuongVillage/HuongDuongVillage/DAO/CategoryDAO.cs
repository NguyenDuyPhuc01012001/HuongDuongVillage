﻿namespace HuongDuongVillage.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            private set => instance = value;
        }

        private CategoryDAO()
        { }

        //public List<CategoryDTO>GetListCategoryByName(string name)
        //{
        //    List<CategoryDTO> categories = new List<CategoryDTO>();
        //    string query = string.Format("SELECT * FROM FoodCategory fc where fc.name like N'%{0}%'", name);
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach(DataRow item in data.Rows)
        //    {
        //        CategoryDTO category = new CategoryDTO(item);
        //        categories.Add(category);
        //    }
        //    return categories;
        //}
        //public List<CategoryDTO> GetListCategory()
        //{
        //    List<CategoryDTO> categories = new List<CategoryDTO>();
        //    string query = "SELECT * FROM FoodCategory";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        CategoryDTO category = new CategoryDTO(item);
        //        categories.Add(category);
        //    }
        //    return categories;
        //}

        //public List<CategoryDTO>GetListCategoryByNameAscending(string name)
        //{
        //    List<CategoryDTO> categories = new List<CategoryDTO>();
        //    if(string.IsNullOrWhiteSpace(name))
        //    {
        //        string query = "SELECT * FROM FoodCategory fc order by fc.name asc";
        //        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //        foreach(DataRow item in data.Rows)
        //        {
        //            CategoryDTO category = new CategoryDTO(item);
        //            categories.Add(category);
        //        }
        //    }
        //    else
        //    {
        //        string query = string.Format("SELECT * FROM FoodCategory fc where fc.name like N'%{0}%' order by fc.name asc", name) ;
        //        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //        foreach (DataRow item in data.Rows)
        //        {
        //            CategoryDTO category = new CategoryDTO(item);
        //            categories.Add(category);
        //        }

        //    }
        //    return categories;
        //}
        //public List<CategoryDTO> GetListCategoryByNameDescending(string name)
        //{
        //    List<CategoryDTO> categories = new List<CategoryDTO>();
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        string query = "SELECT * FROM FoodCategory fc order by fc.name desc";
        //        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //        foreach (DataRow item in data.Rows)
        //        {
        //            CategoryDTO category = new CategoryDTO(item);
        //            categories.Add(category);
        //        }
        //    }
        //    else
        //    {
        //        string query = string.Format("SELECT * FROM FoodCategory fc where fc.name like N'%{0}%' order by fc.name desc", name);
        //        DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //        foreach (DataRow item in data.Rows)
        //        {
        //            CategoryDTO category = new CategoryDTO(item);
        //            categories.Add(category);
        //        }

        //    }
        //    return categories;
        //}
        //public bool InsertCategory(string name)
        //{
        //    string query = "INSERT FoodCategory VALUES ('" + name + "')";
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool UpdateCategory(string name, int id)
        //{
        //    string query = string.Format("UPDATE FoodCategory Set name = N'{0}' where id = {1}", name, id);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        //public bool DeleteCategory(int id)
        //{
        //    string query = string.Format("Delete FoodCategory where id = {0}", id);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}

        //public string GetCategoryByID(int id)
        //{
        //    string query = string.Format("SELECT fc.name FROM FoodCategory fc where fc.id = " + id);
        //    string name = DataProvider.Instance.ExecuteScalar(query).ToString();
        //    return name;
        //}

        //public int GetIDCategoryByName(string name)
        //{
        //    string query = string.Format("SELECT FoodCategory.id FROM FoodCategory where FoodCategory.name = N'{0}'", name);
        //    int id = DataProvider.Instance.ExecuteNonQuery(query);
        //    return id;
        //}
    }
}