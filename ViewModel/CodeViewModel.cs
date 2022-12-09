using ekz2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace ekz2.ViewModel
{
    class CodeViewModel : ViewModelBase
    {
        public ApplicationContext db { get; set; }
        private List<Customer4> customers;
        public List<Customer4> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
                OnPropertyChanged("Customers");
            }
        }
        private Customer4 selectedCustomer;
        public Customer4 SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }


        private List<Diagnosis> diagnosis { get; set; }
        public List<Diagnosis> Diagnosis
        {
            get
            {
                return diagnosis;
            }
            set
            {
                diagnosis = value;
                OnPropertyChanged("Diagnosis");
            }
        }

        private Diagnosis selectedDiagnos;
        public Diagnosis SelectedDiagnos
        {
            get
            {
                return selectedDiagnos;
            }
            set
            {
                selectedDiagnos = value;
                OnPropertyChanged("SelectedDiagnosis");
            }
        }


        public CodeViewModel()
        {
            db = new ApplicationContext();
            this.Customers = db.Customers.ToList();
            this.Diagnosis = db.Diagnosis.ToList();
            DeleteCustomersCommand = new DelegateCommand<object>(DeleteCustomers);
            AddCustomersCommand = new DelegateCommand<object>(AddCustomers);
            EditCustomersCommand = new DelegateCommand<object>(EditCustomers);

            DeleteDiagnosCommand = new DelegateCommand<object>(DeleteDiagnos);
            AddDiagnosisCommand = new DelegateCommand<object>(AddDiagnosis);
            EditDiagnosisCommand = new DelegateCommand<object>(EditDiagnosis);
        }
        //xcus
        public void DeleteCustomers(object obj)
        {
            var b = (Customer4)selectedCustomer;
            var item = db.Customers.Find(b.cnum);
            if (item != null)
                db.Customers.Remove(item);
            db.SaveChanges();
            this.Customers = db.Customers.ToList();
        }
        public ICommand DeleteCustomersCommand { get; set; }
        private void AddCustomers(object obj)
        {
#if true

#endif
            var b = (Customer4)selectedCustomer;

            db.Customers.Add(b);
            db.SaveChanges();
            this.Customers = db.Customers.ToList();
        }
        public ICommand AddCustomersCommand { get; set; }
        private void EditCustomers(object obj)
        {
            var b = (Customer4)selectedCustomer;
            db.Entry(b).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            db.Customers.Update(b);
            db.SaveChanges();
            this.Customers = db.Customers.ToList();
        }
        public ICommand EditCustomersCommand { get; set; }
        //dia
        public void DeleteDiagnos(object obj)
        {

            var b = (Diagnosis)selectedDiagnos;
            var item = db.Diagnosis.Find(b.dnum);
            if (item != null)
                db.Diagnosis.Remove(item);
            db.SaveChanges();
            this.Diagnosis = db.Diagnosis.ToList();
        }
        public ICommand DeleteDiagnosCommand { get; set; }
        private void AddDiagnosis(object obj)
        {
            var b = (Diagnosis)selectedDiagnos;
            var item = db.Diagnosis.Find(b.dnum);
            if (item == null)
                db.Diagnosis.Add(b);
            db.SaveChanges();
            this.Diagnosis = db.Diagnosis.ToList();
        }
        public ICommand AddDiagnosisCommand { get; set; }
        private void EditDiagnosis(object obj)
        {
            var b = (Diagnosis)selectedDiagnos;
            db.Entry(b).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            db.Diagnosis.Update(b);
            db.SaveChanges();
            this.Customers = db.Customers.ToList();
        }
        public ICommand EditDiagnosisCommand { get; set; }
    }
}
