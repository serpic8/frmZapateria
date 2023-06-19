namespace ZapateriaAPI.Models.Dto
{
    public class SalesCreateDto
    {
        public int IDProducto { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
    }
}
