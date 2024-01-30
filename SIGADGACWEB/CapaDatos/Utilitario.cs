using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
  public class Utilitario
    {
        public static Utilitario _instancia = null;

        private Utilitario()
        {

        }

        public static Utilitario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Utilitario();
                }
                return _instancia;
            }
        }


        public String fechaAS400(string ofecha)
        {
            string odate = string.Empty;
            try
            {
                if (ofecha.Trim().Length > 0)
                {
                    DateTime ofechaForato = Convert.ToDateTime(ofecha);
                    odate = ofechaForato.ToString("yyyyMMdd");
                }
            }
            catch
            {
                odate = ofecha;
            }

            return odate;
        }

        public String RetornoAnio(string ofecha)
        {
            string odate = string.Empty;
            try
            {
                if (ofecha.Trim().Length > 0)
                {
                    odate = ofecha.Substring(0, 4);
                }
            }
            catch
            {
                odate = ofecha;
            }

            return odate;
        }
        public string campoNull(string campo)
        {
            if (String.IsNullOrEmpty(campo))
                campo = "";
            return campo;
        }

        public string EstadoNacInt(string campo)
        {
            string estado = string.Empty;
            if (campo.Equals("02"))
            {
                estado = "N";
            }
            else if (campo.Equals("03"))
            {
                estado = "I";
            }
            else if (campo.Equals("04"))
            {
                estado = "N";
            }
            else if (campo.Equals("05"))
            {
                estado = "I";
            }
            return estado;
        }

        public string TipoOperacion(string campo)
        {
            string estado = string.Empty;
            if (campo.Equals("02"))
            {
                estado = "04";
            }
            else if (campo.Equals("03"))
            {
                estado = "05";
            }
            else if (campo.Equals("04"))
            {
                estado = "04";
            }
            else if (campo.Equals("05"))
            {
                estado = "05";
            }
            return estado;
        }

        public string fechaDate(string fecha)
        {
            string fechaNueva = string.Empty;
            if (fecha.Length > 0)
            {
                fechaNueva = fecha.Substring(6, 2) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(0, 4);

            }

            return fechaNueva;
        }

        public string checkBoxString(bool estado)
        {
            if (estado)
                return "1";
            else
                return "0";
        }

        public bool checkBoxBool(string estado)
        {
            if (estado.Equals("1"))
                return true;
            else
                return false;
        }
    }
}
