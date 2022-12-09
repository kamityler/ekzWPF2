using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Input;

namespace ekz2.ViewModel
{
    class DataViewModel : ViewModelBase
    {
        private SqlDataAdapter projectAdapter;
        private DataSet _projectsSet;
        public DataSet ProjectsSet
        {
            get => _projectsSet;
            set
            {
                _projectsSet = value;
                OnPropertyChanged("_projectsSet");
            }
        }

        private DataView _projectsView;

        public DataView ProjectsView
        {
            get => _projectsView;
            set
            {
                _projectsView = value;
                OnPropertyChanged("_projectsView");
            }
        }

        private DataRowView selectedItem;
        public DataRowView SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        SqlConnection con;
        public DataTable Tab { get; set; }

        public DataViewModel()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=PC305\\SQLEXPRESS;database=DanyloBodnarsPurchaseNSale;Trusted_Connection=true";
            projectAdapter = new SqlDataAdapter("SELECT * FROM  dbo.Customers", con);
            ProjectsSet = new DataSet();
            projectAdapter.Fill(ProjectsSet);
            ProjectsView = ProjectsSet.Tables[0].DefaultView;
            Tab = ProjectsView.ToTable();
            var sqlCommandBuilder = new SqlCommandBuilder(projectAdapter);
            SaveCommand = new DelegateCommand<object>(Save);
            DeleteCommand = new DelegateCommand<object>(Delete);

        }

        private void Save(object obj)
        {
            projectAdapter.Update(ProjectsSet);
        }

        public ICommand SaveCommand { get; set; }

        private void Delete(object obj)
        {
            var b = SelectedItem;
            var index = ProjectsSet.Tables[0].Rows.IndexOf((DataRow)b.Row);
            ProjectsSet.Tables[0].Rows[index].Delete();//((DataRow)b.Row);
            projectAdapter.Update(ProjectsSet);
        }
        public ICommand DeleteCommand { get; set; }

    }
}
