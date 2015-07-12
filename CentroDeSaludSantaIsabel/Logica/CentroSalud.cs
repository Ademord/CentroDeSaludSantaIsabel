using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroSaludSantaIsabel
{
    static class CentroSalud
    {
        public static CTRLHistoriaClinica ctrlHC = new CTRLHistoriaClinica();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCentroSalud());
        }
        //System.Windows.Forms.MessageBox.Show(BufferPaciente.Instance.buffer[index_reg_pat].paciente.paciente.Nombres);

        public static void Pacientes(Panel panelDesk)
        {

            FormGestionHC objForm = new FormGestionHC();
            objForm.TopLevel = false;
            panelDesk.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            
            ctrlHC.InitiateService(objForm);
        }
    }
}
/*
 * MainForm: Pacientes ; Salud ; Personal
 * ::Pacientes
 * FormBusqueda con lista de pacientes que se encontraron en la BD
 * BtnPacientes -> FormBusqueda
 *              -> CTRLHC.cargar(FormBusqueda)
 *              -> CTRLHC   -> CTRLDTP.cargarBufferDTP()
 *                          -> if buffer.vacio : 
 *                          ->  BufferDTP = BD.execute(AdaptBDDTP.getAll()).toArray()
 *              -> CTRLHC
 *                  for each DTP in BufferDTP 
 *                      FormBusqueda.FlowLayoutPanel.AddControl(AdaptUCHC.traducir(AdaptDTP.traducir(DTP)));
 * 
 * FormBusqueda.UCHC.Gestionar -> CTRLHC.gestionar(UCHC.index)
 *                             -> CTRLHC    -> FormHC
 *                                          -> FormHC.UCPat = AdaptUCP.traducir(BufferDTP.find(index)) 
 *                                          
 * FormHC: UCPat.Gestionar ; Responsables ; Consultas Enf ; Consultas Medicas ; Guardar
 * 
 * FormHC.UCPat.Gestionar -- done
 * 
 * CTRL<T> 
 * :FlowLayoutPanel
 * +Cargar(FlowLayoutPanel)
 * +Nuevo()
 * +Gestionar(i)
 * +Eliminar(i)
 * 
 * FormHC.Responsables  -> CTRLHC.Responsables()
 *                          -> CTRL.ctrl = FactoriaCTRL.obtener("responsable")
 *                          -> CTRL.index = index_reg_pat;
 *                          -> CTRL.open(new FormGestion());
 *                          
 * FormGestion.Gestionar()  -> CTRL.Gestionar(UC.index)
 *                              -> Form = new ctrl.AdaptUI.traducir(ctrl.AdaptDT.traducir(Buffer.find(index_reg_pat, id_resp = index))));
 *                              -> if (result OK)
 *                              -> Buffer.add(id_reg_pat, INSTRUCTION_TYPE_UPDATE, ctrl.AdaptDT.traducir(ctrl.AdaptUI.traducir(Form))
 *                              -> Cargar(FormGestion)
 *                          
 * FormGestion.Eliminar() -> CTRL.Eliminar(UC.index)
 *                          -> Buffer.eliminar(index_reg_pat,  INSTRUCTION_TYPE_DELETE, id_resp = index);
 *                          -> Cargar(FormGestion);
 *                          
 * FormGestion.Nuevo() -> CTRL.Nuevo()
 *                          -> Form = new ctrl.AdaptUI.form();
 *                          -> if (result OK)
 *                          -> BufferP.add(inde_reg_pat, INSTRUCTION_TYPE_INSERT, ctrl.AdaptDT.traducir(ctrl.AdaptUI.traducir(Form));
 *                          -> Cargar(FormGestion)
 *                          
 * CTRL.Cargar(FormGestion)
 *      -> CTRLRESP.Cargar(FormGestion)
 *          -> CTRLRESP.cargarBuffer(index_pat)
 *          -> for each reg in BufferPat[index_reg_pat][CONF.INDEX_RESP]:
 *              FormGestion.FlowLayoutPanel.AddControl(CTRLRESP.adaptUC.traducir(CTRLRESP.adaptDT.traducir(reg))
 *      
 *      -> CTRLCE.Cargar(FormGestion)
 *          -> CTRLDTCE.cargarBuffer(index_reg_pat)
 *          -> for each DTCE in Buffer[index_reg_pat][CONF.INDEX_CE]:
 *              FormBusquedaFlowLayoutPanel.AddControl(AdaptUC.traducir(AdaptDT.traducir(DTCE))
 *                      
 * 
 * 
 * FormHC.Guardar -> CTRLHC -> CTRLDTP.actualizar|insertar(index)
 *                          -> foreach reg in BufferDT
 *                          ->  GuardarReg(reg)
 *                              -> FactoriaDT.Obtener(reg.header).BD.execute(AdaptBDDTP.insertar|actualizar(reg)
 * 
 * 
*/