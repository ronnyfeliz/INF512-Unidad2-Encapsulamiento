En esta app básica implementé varias funcionalidades esenciales para aplicaciones de escritorio sencillas en C# con WPF.

Primero, usé varios Label para poner títulos principales y secundarios, como los nombres de las pizzas y bebidas, y otro para mostrar el precio final.

Luego, coloqué CheckBox para la lista de pizzas (porque se pueden elegir varias al mismo tiempo) y RadioButton para las bebidas (porque solo se puede escoger una).

Agregué botones para las acciones principales:

Ordenar: calcula el precio sumando los valores de las pizzas y bebida seleccionadas, y lo muestra en un Label. Si no elegiste ninguna pizza, aparece un mensaje de advertencia.
Cancelar: limpia todas las selecciones (desmarca los CheckBox y RadioButton), pone el precio en 0 y reactiva los botones si es necesario.
Clear (o "Limpiar mesa"): hace lo mismo que Cancelar, resetea todo a cero.
Volver a ordenar: reactiva los botones de Ordenar y Cancelar después de una orden.
Exit (Salir): cierra la aplicación completamente usando el método Shutdown.
También usé un Label (en lugar de TextBox) para mostrar el resultado del precio en pantalla de forma clara, con formato como "450.00$RD".

En resumen, esta aplicación muestra cómo manejar selecciones del usuario, calcular un total simple, validar que se elija al menos algo importante, limpiar los datos y salir de la app. Todo con controles básicos y eventos de clic, ideal para entender el funcionamiento de una interfaz gráfica sencilla en escritorio.

Aunque el foro menciona Windows Forms, usé WPF porque es la versión más moderna de Microsoft para apps de escritorio, y me permitió aprender conceptos útiles como eventos y controles visuales. El código funciona bien y cumple el objetivo de crear una app práctica.
