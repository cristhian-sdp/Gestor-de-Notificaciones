# Proyecto de Gestión de Notificaciones (Listas Enlazadas Simples)

Este proyecto implementa un gestor de notificaciones utilizando una estructura de datos de Lista Enlazada Simple creada desde cero en C#.

## Estructura del Proyecto

* **Nodo.cs**: Clase base que representa un elemento en la lista enlazada (contiene Monto y Siguiente).
* **Lista.cs**: Lógica central de la lista enlazada, incluyendo inserción, eliminación, búsqueda, ordenamiento (Merge Sort) y mezcla.
* **FormMain.cs**: Interfaz de usuario de Windows Forms para interactuar visualmente con la lista.
* **Program.cs**: Punto de entrada de la aplicación.

## Instrucciones para ejecutar manualmente (Casos de prueba)

1. Abre el proyecto en Visual Studio.
2. Compila y ejecuta el proyecto.  
3. Verás una ventana principal con varias opciones:
	* Un panel a la izquierda con botones para cada operación.
	* Entradas de texto para Monto y Posición.
	* Una lista central donde se dibujan los nodos actuales.
	* Un registro de bitácora a la derecha para ver los resultados de cada acción.
4. Puedes interactuar manualmente introduciendo montos (y posiciones) y viendo cómo la lista se actualiza visualmente, incluyendo mensajes en caso de errores y estado actual en formato texto arriba.
5. **Para probar todos los casos de prueba requeridos de forma automatizada:**
	* Haz clic en el botón superior derecho **"Ejecutar Casos de Prueba"**.
	* El sistema vacea la lista y empieza a correr los 12 casos programados internamente, uno por uno.
	* Los resultados indican "PASA" o "FALLA" para cada caso de prueba.
