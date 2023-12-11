using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Cobranzas.Models.Bean
{
    public class Base_General
    {
        public int ID_BASE { get; set; }
        [Display(Name = "Álbum")]
        [RegularExpression(@"^[0-9]+$|^SIN INFO$", ErrorMessage = "Ingrese un álbum válido o 'SIN INFO' si no tiene la información")]
        [Required(ErrorMessage = "Ingrese un valor de Álbum")]
        public string ALBUM { get; set; } = null!;
        [Display(Name = "Fecha de Consignación")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_CONSIGNACION { get; set; }
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Ingrese un valor de marca")]
        public string MARCA { get; set; }=null!;
        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "Ingrese un valor de modelo")]
        public string MODELO { get; set; } = null!;
        [Display(Name = "Precio Pactado")]
        [Required(ErrorMessage ="Ingrese un valor para el precio pactado")]
        public decimal PRECIO_PACTADO { get; set; }
        [Display(Name = "Contrato")]
        [RegularExpression(@"^[0-9]+$|^SIN INFO$", ErrorMessage = "Ingrese un contrato válido o 'SIN INFO' si no tiene la información")]
        [Required(ErrorMessage = "Ingrese un valor de Contrato")]
        public string CONTRATO { get; set; } = null!;
        [Display(Name = "Tipo de documento")]
        public int ID_DOCUMENTO { get; set; }
        [Display(Name = "Número de Documento")]
        [Required(ErrorMessage ="Ingrese número de documento o 'SIN INFO' si no tiene información sobre ello")]
        public string NUMERO_DOCUMENTO { get; set; } = null!;
        [Display(Name = "Propietario")]
        [Required(ErrorMessage ="Ingrese el nombre del propietario")]
        public string NOMBRE_PROPIETARIO { get; set; } = null!;
        [Display(Name = "Tipo")]
        public string TIPO { get; set; } = null!;
        [Display(Name = "Celular")]
        [RegularExpression(@"^9\d{8}$|^SIN INFO$", ErrorMessage = "Ingrese un número válido o 'SIN INFO' si no tiene la información.")]
        [Required(ErrorMessage = "Ingrese un número de celular")]
        public string CELULAR { get; set; } = null!;
        [Display(Name = "Celular 2")]
        [RegularExpression(@"^9\d{8}$|^SIN INFO$", ErrorMessage = "Ingrese un número válido o 'SIN INFO' si no tiene la información.")]
        [Required(ErrorMessage = "Ingrese otro número de celular o 'SIN INFO' ´si no tiene")]
        public string CELULAR2 { get; set; } = null!;
        [Display(Name = "Correo")]
        [RegularExpression(@"^.*@.*$|^SIN INFO$", ErrorMessage = "El correo debe contener '@' o ser 'SIN INFO'")]
        [Required(ErrorMessage = "Ingrese un correo electrónico")]
        public string CORREO { get; set; } = null!;
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Ingrese la dirección del cliente")]
        public string DIRECCION { get; set; } = null!;
        [Display(Name = "Distrito")]
        public int ID_DISTRITO { get; set; }
        [Display(Name = "Tipo de penalidad")]
        public string? TIPO_PENALIDAD { get; set; }
        [Display(Name = "Pagaré")]
        public string? PAGARE { get; set; }
        [Display(Name = "Fecha de cobro")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_COBRO { get; set; }
        [Display(Name = "Status de cliente")]
        public int ID_STATUS_CLIENTE { get; set; }
        [Display(Name = "Demanda interna principal")]
        public int ID_DEMANDA_INTERNA_PRINCIPAL { get; set; }
        [Display(Name = "Demanda principal judicial")]
        public int ID_DEMANDA_PRINCIPAL_JUDICIAL { get; set; }
        [Display(Name = "Fecha ingreso de demanda")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_INGRESO_DEMANDA { get; set; }
        [Display(Name = "Fecha de arbitraje")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_ARBITRAJE { get; set; }
        [Display(Name = "Tipo de moneda")]
        public int ID_MONEDA { get; set; }
        [Display(Name = "Penalidad")]
        [Required(ErrorMessage ="Ingrese una penalidad")]
        public Decimal PENALIDAD { get; set; }
        [Display(Name = "Mora diaria")]
        public Decimal MORA { get; set; }
        [Display(Name = "Mora total")]
        public Decimal MORA_TOTAL { get; set; }
        [Display(Name = "Dias de mora")]
        public int DIAS_MORA { get; set; }
        [Display(Name = "Gastos de cobranza")]
        public Decimal GASTOS_COBRANZA { get; set; }
        [Display(Name = "Gastos de cochera")]
        public Decimal GASTOS_COCHERA { get; set; }
        [Display(Name = "Fecha de embargo")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_EMBARGO { get; set; }
        [Display(Name = "Gastos de cochera total")]
        public Decimal GASTOS_COCHERA_TOTAL { get; set; }
        [Display(Name = "Gasto total")]
        public Decimal GASTO_TOTAL { get; set; }
        [Display(Name = "Status SUNARP")]
        public string? STATUS_SUNARP { get; set; }
        [Display(Name = "Marca auto cautelar")]
        [Required(ErrorMessage = "Ingrese una marca de auto cautelar")]
        public string MARCA_AUTO_CAUTELAR { get; set; } = null!;
        [Display(Name = "Modelo auto cautelar")]
        [Required(ErrorMessage = "Ingrese una modelo de auto cautelar")]
        public string MODELO_AUTO_CAUTELAR { get; set; } = null!;
        [Display(Name = "Fecha auto cautelar")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_AUTO_CAUTELAR { get; set; }
        [Display(Name = "Partida registral auto cautelar")]
        [Required(ErrorMessage = "Ingrese una partida de auto registral")]
        public string PARTIDA_REGISTRAL_AUTO_CAUTELAR { get; set; } = null!;
        [Display(Name = "Placa auto cautelar")]
        [Required(ErrorMessage = "Ingrese una placa de auto cautelar")]
        public string PLACA_AUTO_CAUTELAR { get; set; } = null!;
        [Display(Name = "Status interno de MC ")]
        public int ID_STATUS_JUDICIAL { get; set; }
        [Display(Name = "Status del PJ de MC")]
        public int ID_STATUS_PODER_JUDICIAL { get; set; }
        [Display(Name = "Pasos de Cobranza")]
        public int ID_PASO_COBRANZA { get; set; }
        [Display(Name = "Fecha de ingreso de MC")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_INGRESO_MC { get; set; }
        [Display(Name = "Fecha de concesorio")]
        [Range(typeof(DateTime), "1/1/1850", "1/1/2100", ErrorMessage = "Ingrese una fecha válida")]
        public DateTime FECHA_CONCESORIO { get; set; }
        [Display(Name = "Apoderado")]
        public int ID_APODERADO { get; set; }
        [Display(Name = "Procurador")]
        public int ID_PROCURADOR { get; set; }
        [Display(Name = "Tipo de Juzgado")]
        public string? TIPO_JUZGADO { get; set; }
        [Display(Name = "Distrito de Juzgado")]
        public int ID_DISTRITO_JUZGADO { get; set; }
        [Display(Name = "Número de juzgado")]
        [Required(ErrorMessage = "Ingrese un número de juzgado")]
        public string NUMERO_DE_JUZGADO { get; set; } = null!;
        [Display(Name = "Número de expediente")]
        [Required(ErrorMessage = "Ingrese un número de expediente")]
        public string? NUMERO_EXPEDIENTE { get; set; }
        [Display(Name = "Código cautelar")]
        [Required(ErrorMessage = "Ingrese un código cautelar")]
        public string CODIGO_CAUTELAR { get; set; } = null!;
        [Display(Name = "Nombre especialista")]
        [Required(ErrorMessage = "Ingrese un nombre de especialista")]
        public string NOMBRE_ESPECIALISTA { get; set; } = null!;
        [Display(Name = "Monto petitorio")]
        [Required(ErrorMessage = "Ingrese un monto petitorio")]
        public Decimal MONTO_PETITORIO { get; set; }
        [Display(Name = "Tipo de impulso")]
        public int ID_TIPO_IMPULSO { get; set; }
        [Display(Name = "Usuario registral")]
        public int ID_USUARIO { get; set; }
        [Display(Name = "Tipo de solicitud de MC")]
        public string? TIPO_SOLICITUD_MEDIDA_CAUTELAR { get; set; }
        [Display(Name = "Respuesta de MC")]
        public string? RESPUESTA_MEDIDA_CAUTELAR { get; set; }
        [Display(Name = "MC")]
        public string MEDIDA_CAUTELAR { get; set; } = null!;
        [Display(Name = "Estado de registro")]
        public string? ESTADO_REGISTRO {get;set;}
    }
}
