using System;
using Entidades;
using TestEntidades.Métodos_de_extensión;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Juan", "Perez", 56);

            //#1.- COMO MUESTRO SUS ATRIBUTOS??? (de tipo protected)


            #region Respuestas

            #region #1.- Agregar propiedades (o métodos getters)

            //#1.- AGREGANDO PROPIEDADES (O METODOS GETTERS)
            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Apellido: {0}", p.Apellido);
            Console.WriteLine("Edad: {0}", p.Edad);

            Console.ReadLine();

            //PERO... 
            //#2.- Y SI LO TENGO QUE UTILIZAR MUUUUUUUUCHAS VECES???

            #endregion


            #region #2.- Agregar Método

            //AGREGO UN METODO QUE INTERNAMENTE INVOQUE A LAS PROPIEDADES (O GETTERS)

            Console.WriteLine(p.ObtenerInfo());

            Console.ReadLine();

            //PERO...
            //#3.- Y SI NO PUEDO ACCEDER AL CODIGO FUENTE (DLL EXTERNA)???


            #region "Dll Externa"

            Entidades.Externa.Persona pe = new Entidades.Externa.Persona("Juan", "Perez", 56);

            Console.WriteLine(pe.ToString()); // Entidades.Externa.Persona

            Console.ReadLine();

            #endregion


            #region #3.- Derivar la Clase de la Dll externa

            //DERIVO LA CLASE DE LA DLL EXTERNA Y LE AGREGO UN METODO....

            #region "DLL Externa Derivada"

            PersonaExternaConMetodo pcm = new PersonaExternaConMetodo("Juan", "Perez", 56);
            
            Console.WriteLine(pcm.ObtenerInfo());

            Console.ReadLine();

            //...Y SI NO SE PUEDE DERIVAR LA CLASE BASE (SEALED)???           
            //:(


            #region Métodos de Extensión

            //“Los métodos de extensión permiten “agregar” métodos a los tipos existentes sin necesidad de crear un 
            //nuevo tipo derivado y volver a compilar o sin necesidad de modificar el tipo original. 
            //Los métodos de extensión constituyen un tipo especial de método estático, pero se les llama como si se 
            //tratasen de métodos de instancia en el tipo extendido. En el caso del código de cliente escrito en C# y Visual Basic, 
            //no existe ninguna diferencia aparente entre llamar a un método de extensión y llamar a los métodos 
            //realmente definidos en un tipo.” MSDN

            #region Para clases propias

            Console.WriteLine(p.ObtenerInfoExtension());

            Console.ReadLine();

            #endregion

            #region Para clases de terceros

            Entidades.Externa.Sellada.Persona ps = new Entidades.Externa.Sellada.Persona("Juan", "Perez", 56);

            Console.WriteLine(ps.ObtenerInfoExtension());

            Console.ReadLine();

            #endregion

            #region Para object

            string nulo = null;

            if (nulo.EsNulo())
            {
                Console.WriteLine("Es nulo");
            }
            else
            {
                Console.WriteLine("NO es nulo");
            }

            if (!ps.EsNulo())
            {
                bool rta = ps.CompararNombreExtensionParam("Roberto");

                Console.WriteLine(rta);
            }

            Console.ReadLine();

            #endregion

            #region Para string

            string cadena = @"Los métodos de extensión permiten “agregar” métodos a los tipos existentes sin necesidad de crear un 
            nuevo tipo derivado y volver a compilar o sin necesidad de modificar el tipo original. 
            Los métodos de extensión constituyen un tipo especial de método estático, pero se les llama como si se  
            tratasen de métodos de instancia en el tipo extendido. En el caso del código de cliente escrito en C# y Visual Basic,
            no existe ninguna diferencia aparente entre llamar a un método de extensión y llamar a los métodos
            realmente definidos en un tipo. MSDN";

            Console.WriteLine("Cantidad de palabras: {0}", cadena.CantidadDePalabras());

            string otraCadena = @"Deben estar contenidos en clases estáticas.
                                Deben ser estatáticos.
                                Se debe indicar a qué clase se extiende mediante la palabra reservada this.";

            Console.WriteLine("Cantidad de palabras: {0}", otraCadena.CantidadDePalabras());

            string conclusion = @"Gracias a los métodos de extensión se puede obtener un código más legible y mantenible, 
                                pero tiene sus inconvenientes:
                                El ciclo de vida de la clase y de los métodos que la extienden pueden ser diferentes
                                Sin el Intellisense es muy difícil saber si un método pertenece a una clase o la extiende
                                Si se agrega en la clase extendida un método con el mismo nombre que el extendido, 
                                el extensor dejará de funcionar.
                                A pesar de estas contras, esta funcionalidad es tan potente, que herramientas como Linq 
                                están construidas con esta técnica de desarrollo.";

            Console.WriteLine(conclusion);

            #endregion

            #endregion

            #endregion

            #endregion

            #endregion

            #endregion



            Console.ReadLine();
        }
    }
}
