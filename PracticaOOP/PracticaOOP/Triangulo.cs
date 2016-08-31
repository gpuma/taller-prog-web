using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaOOP
{
    /*
     * un triangulo es un polígono de TRES lados
     * 
     * TODO: 2. agregue el código necesario para que
     * la clase Triangulo herede de la clase Polígono
    */
    public class Triangulo
    {
        /*
         * TODO: 3. añada tres atributos que representen
         * la longitud de los tres lados del triángulo
         */

        public Triangulo()
        {
            /*
             * Este es un constructor, recuerde que este método
             * se llama cada vez que se instancia un objeto de la clase
             * 
             * TODO: 4. Agregue el código necesario para que el atributo
             * de número de lados tenga el valor correspondiente (tres lados)
             * cuando se crea un Triangulo
             */
        }

        /*
         * TODO: 5. Cree un nuevo constructor que tome como argumentos
         * la longitud de los tres lados del triangulo
         * y asigne esos argumentos a los atributos que ya creó en el paso 3
         */

        /*
         * TODO: 6. Cree una propiedad pública vinculada al atributo nroLados
         * de la clase padre. Revise las diapositivas
         */
        
        public double CalcularArea()
        {
            double resultado = 0;

            /*
             * TODO: 7. Complete el método que calcula el área de un triángulo.
             * la manera más simple es usar la fórmula de Herón:
             * https://es.wikipedia.org/wiki/F%C3%B3rmula_de_Her%C3%B3n
             * TIP: Para calcular la raíz cuadrada de un número
             *      use la función Math.Sqrt()
             */

            return resultado;
        }
    }
}