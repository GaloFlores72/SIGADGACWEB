﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class tbUsuario
    {
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string TipoIdentificacion { get; set; }
        public string CedulaIdentificacion { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string EstadoActividad { get; set; }
        public string TipoAplicacion { get; set; }
        public string IdentificacionTributaria { get; set; }
        public string NumeroRuc { get; set; }
        public string CodigoCiudad { get; set; }
        public string CodigoDependencia { get; set; }
        public string CodigoSubsistema { get; set; }
        public string CodigoGestion { get; set; }
        public string CodigoModulo { get; set; }
        public string CodigoRol { get; set; }
        public string CentroContable { get; set; }
        public List<tbRol> oListaRol { get; set; }
        public List<tbMenu> oListaMenu { get; set; }
        public string UsuarioCreado { get; set; }
        public string FechaCreado { get; set; }
        public string HoraCreado { get; set; }
        public string DispositivoCreacion { get; set; }
        public string UsuarioModificado { get; set; }
        public string FechaModificado { get; set; }
        public string HoraModificado { get; set; }
        public string DispositivoModificacion { get; set; }
        public string DescripcionSubSistema { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string fechaSistema { get; set; }
        public string TipoHorario { get; set; }
        public string NumeroAleatorio { get; set; }
        public string NombreCorto { get; set; }
        public string Cargo { get; set; }

        public List<tbDetalleRepresentanteLegal> oListaRepresentanteLegal { get; set; }
    }
}
