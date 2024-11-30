using CatalogoVisual.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoVisual.controlador
{
    
    public partial class GestionAv
    {
        public int EliminarElemento(int index)
        {
            String titulo = FrmMenuPrincipal.avs[index].Titulo;

            DialogResult opc = MessageBox.Show($"Está a punto de eliminar {titulo}\n¿Estás seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if (opc == DialogResult.OK)
            { 
                FrmMenuPrincipal.avs.RemoveAt(index);

                MessageBox.Show($"{titulo} ha sido eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (FrmMenuPrincipal.avs.Count <= 0)
                {
                    DialogResult opc2 = MessageBox.Show($"No hay elementos que mostrar\n¿Deseas dar de alta uno?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (opc2 == DialogResult.OK)
                    {
                        return 1;
                    }
                    else if (opc2 == DialogResult.Cancel)
                    {
                        return 2;
                    }
                }
            }
            else if (opc == DialogResult.Cancel)
            {
                // Acción para cancelar la operación
                MessageBox.Show("Operación cancelada. No se eliminó ningún elemento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return 0;
        }
    }
}
