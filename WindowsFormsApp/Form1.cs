using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Abstract;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //ninject came...
            //_productService = new ProductManager(new EfProductDal());
            //_categoryService = new CategoryManager(new EfCategoryDal());
            _courseService = InstanceFactory.GetInstance<ICourseService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private ICourseService _courseService;
        private ICategoryService _categoryService;
        private ICourseService

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

        }

        private void LoadCourses()
        {
            dgwProduct.DataSource = _courseService.GetAll();
        }

       



    }
}
