using System;
using System.Collections.Generic;
using System.Text;

namespace MyStuff
{
    public static class ObjetosGlobales
    {
        //Acá almacenamos la información que permite el consumo de las rutas de producción y pruebas 
        //del API 
        public static string RutaProduccion = "http://192.168.0.160:45457/api/";
        public static string RutaPruebas = "http://192.168.0.160:45457/api/";

        //agregamos la info de seguridad ya sea JWT o ApiKey como en este caso 
        public static string ApiKeyName = "ApiKey";
        public static string ApiKeyValue = "1234qwertyABC";
    }
}
