using Cobranzas.Models.Interface;

namespace Cobranzas.Models.Bean
{
    public class Cuota
    {
       public int ID_CUOTA { get; set; }
	   public int ID_DEUDA { get; set; }
	   public int ID_BANCO { get; set; }
	   public string MEDIO_PAGO { get; set; }
	   public string CUENTA_BANCARIA { get; set; }
	   public int ID_MONEDA { get; set; }
       public Decimal MONTO { get; set; } 
	   public string TIPO_PAGO { get; set; }
	   public string NUMERO_OPERACION { get; set; }
	   public DateTime FECHA_PAGO { get; set; }
       public string INSTANCIA_PAGO { get; set; }
	   public int ID_USUARIO { get; set; }
    }
}
