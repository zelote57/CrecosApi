﻿namespace CrecosApi.Models
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }        
        public decimal Costo { get; set; }
    }
}
