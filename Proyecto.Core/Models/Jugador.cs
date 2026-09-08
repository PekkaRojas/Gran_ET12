using System;

namespace Models
{
    public class Jugador
    {
        private ushort _id {get; set;}
        private string _nombre {get; set;}
        private string _apellido {get; set;}
        private string _apodo {get; set;} = string.Empty;
        private DateTime _fechaNacimiento {get; set;} = DateTime.MinValue;
        private byte _idEquipo {get; set;}
        private float _cotizacion {get; set;}
        private byte _idPosicion {get; set;}
    }
}