using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroSaludSantaIsabel
{
    class CTRLHistoriaClinica: CTRL<FormHistoriaClinica>
    {
        AdaptadorUCHClinica adaptadorUC = new AdaptadorUCHClinica();
        AdaptadorUIHC adaptadorUI = new AdaptadorUIHC();
        public override void InitiateService(Object form)
        {
            this.flowLayout = ((FormGestionHC)form).flowLayoutPanel;
            ((FormGestionHC)form).Show();
        }

        public override FormHistoriaClinica OpenForm(int index_reg_pat)
        {
            FormHistoriaClinica form = new FormHistoriaClinica();
            if (index_reg_pat != CONFIG.NEW_REG)
            {
                BufferPaciente.Instance.temp = BufferPaciente.Instance.buffer[index_reg_pat];
                form = adaptadorUI.Traducir(BufferPaciente.Instance.buffer[index_reg_pat].paciente);
            }
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return form;
            else return null;
        }
        protected override void InsertItem(FormHistoriaClinica form)
        {
            BufferPaciente.Instance.temp.tipoRegistro = TipoRegistroDT.DIRTY_REG_INSERT;
            BufferPaciente.Instance.AddTemp();
        }
        public override void LoadTempIntoFlowLayout(){
            DTPaciente last_added = BufferPaciente.Instance.buffer[BufferPaciente.Instance.buffer.Count - 1].paciente;
            UCHistoriaClinica ucp = this.adaptadorUC.Traducir(last_added);
            //ucp.labelApellidos.Text = last_added.id.ToString();
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.Add(ucp);
            BufferPaciente.Instance.DropTemp();
        }
        public override void LoadTempIntoFlowLayout(Object UC, int index)
        {
            DTPaciente last_modified = BufferPaciente.Instance.buffer[index].paciente;
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.Remove((UCHistoriaClinica) UC);
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.
                Add(this.adaptadorUC.Traducir(last_modified));
            BufferPaciente.Instance.DropTemp();
        }
        protected override void UpdateItem(int reg_index, FormHistoriaClinica form)
        {
            if (BufferPaciente.Instance.temp.tipoRegistro == TipoRegistroDT.CLEAN_REG)
            {
                BufferPaciente.Instance.temp.tipoRegistro = TipoRegistroDT.DIRTY_REG_UPDATE;
            }
            BufferPaciente.Instance.buffer[reg_index] = BufferPaciente.Instance.temp; 
        }
        protected override void DeleteItem(int reg_index)
        {
            TipoRegistroDT tipoReg = BufferPaciente.Instance.buffer[reg_index].tipoRegistro;
            if (tipoReg == TipoRegistroDT.DIRTY_REG_INSERT)
            {
                BufferPaciente.Instance.buffer.RemoveAt(reg_index);
            }
            else
            {
                BufferPaciente.Instance.buffer[reg_index].tipoRegistro = TipoRegistroDT.DIRTY_REG_DELETE;
                CTRLDTHC.SetDeletes(reg_index);
            }
        }
        public override void LoadDataBaseToBuffer()
        {
            int a;
        }
        public override void LoadBufferToFlowLayoutPanel()
        {
            int a;
        }
        public override void SaveBufferToBD()
        {
            CTRLDTHC.SaveBufferToBD();
        }
        public override void RemoveUCFromLayout(object UC)
        {
            ((System.Windows.Forms.FlowLayoutPanel)this.flowLayout).Controls.Remove((UCHistoriaClinica)UC);
        }
    }
}
