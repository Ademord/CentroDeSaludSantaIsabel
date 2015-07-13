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
                form.ucPaciente.index_paciente = index_reg_pat;
            }
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && BufferPaciente.Instance.temp.tipoRegistro != TipoRegistroDT.CLEAN_REG)
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
            ucp.index_paciente = BufferPaciente.Instance.buffer.Count - 1;
            ucp.labelApellidos.Text = ucp.index_paciente.ToString() + " : " + BufferPaciente.Instance.buffer[ucp.index_paciente].paciente.id.ToString();
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.Add(ucp);
            BufferPaciente.Instance.DropTemp();
        }
        public override void LoadTempIntoFlowLayout(Object UC, int index)
        {
            DTPaciente last_modified = BufferPaciente.Instance.buffer[((UCHistoriaClinica)UC).index_paciente].paciente;
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.Remove((UCHistoriaClinica) UC);
            ((UCHistoriaClinica)UC).Dispose();
            UCHistoriaClinica ucp = adaptadorUC.Traducir(last_modified);
            ucp.index_paciente = ((UCHistoriaClinica)UC).index_paciente;
            ucp.labelApellidos.Text = ucp.index_paciente.ToString() + " : " + BufferPaciente.Instance.buffer[ucp.index_paciente].paciente.id.ToString();
            ((System.Windows.Forms.FlowLayoutPanel) this.flowLayout).Controls.
                Add(ucp);
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
            //factoria estrategia . obtener ("paciente")
            //estrategia.loadbufferFromBD()
            CTRLDTHC.LoadBufferPacientesFromBD();
        }
        public override void LoadBufferToFlowLayoutPanel()
        {
            for (int i = 0; i < BufferPaciente.Instance.buffer.Count; i++)
            {
                UCHistoriaClinica ucp = this.adaptadorUC.Traducir(BufferPaciente.Instance.buffer[i].paciente);
                ucp.index_paciente = i;
                //ucp.labelApellidos.Text = ucp.index_paciente.ToString() + " : " + BufferPaciente.Instance.buffer[ucp.index_paciente].paciente.id.ToString();
                ((System.Windows.Forms.FlowLayoutPanel)this.flowLayout).Controls.
                    Add(ucp);
            }
        }
        public override void SaveBufferToBD()
        {
            try
            {
                CTRLDTHC.SaveBufferToBD();
                System.Windows.Forms.MessageBox.Show("Cambios guardados!");
            }
            catch (Npgsql.NpgsqlException e)
            {
                System.Windows.Forms.MessageBox.Show("No se pudo guardar en la BD! " + e.ErrorSql + e.Hint);
            }
        }
        public override void CleanBuffer()
        {
            BufferPaciente.Instance.DropBuffer();
        }
        public override void RemoveUCFromLayout(object UC)
        {
            ((System.Windows.Forms.FlowLayoutPanel)this.flowLayout).Controls.Remove((UCHistoriaClinica)UC);
        }
    }
}
