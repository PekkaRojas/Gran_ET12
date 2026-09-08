using System;
namespace Models
{
    public class Puntuacion
    {
        public int Id { get; set; }
        public ushort IdJugador { get; set; }
        public byte Fecha { get; set; }
        public float Puntuacion { get; set; }
    }
}