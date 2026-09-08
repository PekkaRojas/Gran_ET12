using System;
namespace Models
{
    public class Puntuacion
    {
        private int _id { get; set; }
        private ushort _idJugador { get; set; }
        private byte _fecha { get; set; }
        private float _puntuacion { get; set; }
    }
}