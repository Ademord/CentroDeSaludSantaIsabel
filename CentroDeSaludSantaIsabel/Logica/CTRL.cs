using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;  

namespace CentroSaludSantaIsabel
{
    
    abstract class CTRL<FormT>
    {
        static Thread ms_oThread = null;

        protected Object flowLayout;
        public abstract void InitiateService(Object form);
        public abstract FormT OpenForm(int reg_index);
        protected abstract void InsertItem(FormT form);
        protected abstract void UpdateItem(int reg_index, FormT form);
        protected abstract void DeleteItem(int reg_index);
        public abstract void LoadTempIntoFlowLayout();
        public abstract void LoadTempIntoFlowLayout(object UC, int index);
        public abstract void RemoveUCFromLayout(object UC);

        public abstract void LoadDataBaseToBuffer();
        public abstract void LoadBufferToFlowLayoutPanel();
        public abstract void SaveBufferToBD();
        public abstract void CleanBuffer();

        public void Nuevo()
        {
            FormT form = OpenForm(CONFIG.NEW_REG);
            if (form != null)
            {
                InsertItem(form);
                LoadTempIntoFlowLayout();
            }
        }

        public void Gestionar(object UC, int reg_index)
        {
            FormT form = OpenForm(reg_index);
            if (form != null)
            {
                UpdateItem(reg_index, form);
                LoadTempIntoFlowLayout(UC, reg_index);
            } 
        }
        public void Eliminar(object UC, int reg_index)
        {
            DeleteItem(reg_index);
            RemoveUCFromLayout(UC);
        }
        public void Save()
        {
            SaveBufferToBD();
            Load();
        }
        public void Load()
        {
            CleanLayout();
            CleanBuffer();
            LoadingIndicator();
            LoadDataBaseToBuffer();
            LoadBufferToFlowLayoutPanel();
        }

        public async void LoadingIndicator()
        {
            PleaseWaitForm pleaseWait = new PleaseWaitForm();
            pleaseWait.Show();
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(1.5));
            pleaseWait.Close();

        }
        public void CleanLayout()
        {
            List<System.Windows.Forms.Control> listControls =
                    ((System.Windows.Forms.FlowLayoutPanel)this.flowLayout).Controls.Cast<System.Windows.Forms.Control>().ToList();

            foreach (System.Windows.Forms.Control control in listControls)
            {
                ((System.Windows.Forms.FlowLayoutPanel)this.flowLayout).Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
