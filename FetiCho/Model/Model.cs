﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceModelView;

namespace Model
{
    public class Model : IModel
    {
        private Model model = null;
        private Model()
        {

        } 
        public Model getInstance() {

            if (model == null)  model = new Model();
            return model;
            
        }
        public DataList GetStoredDataByDate(DateTime date) { return new DataList(); }

        public Boolean ImportDataFromTxt() { return true; }

        public RecipientList ImportRecipientList() { return new RecipientList(); }

        public Boolean AddRecipient(String email, String name) { return true; }

        public Boolean DeleteRecipient(int id_recipient) { return true; }

        public Boolean ExportToPdf(String email, DataList datalist) { return true; }

        public Boolean ExportToCsv(DataList datalist) { return true; }
    }
}
