using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismApp.Models;
using Prism.Mvvm;

namespace PrismApp.ViewModels
{
    class TestViewModel:BindableBase
    {
        private TestModel testModel;
        public TestViewModel()
        {
            testModel = new TestModel();
            testModel.Message = "this is prism example";
        }

        public TestModel TestModel
        {
            get
            {
                return testModel;
            }
            set
            {
                SetProperty(ref testModel, value);
            }
        }
    }
}
