# ExamenQuark


## Algunos comments :)

- Me arrepiento toda la vida de haber encarado el menu usando Console, vengo de Java y me encontré que el manejo
  de consola es bastante distinto en C# ( o al menos no estoy familiarizado).. y me robó el 60% del tiempo del proyecto :(
- Habiendo dicho esto , disculpas por el look and feel.. espero que al menos la funcionalidad cumpla con lo solicitado.

RESPUESTAS PARTE H:

1 - C# no permite herencia múltiple , pero al igual que Java (y otros) se puede llegar en varias ocaciones a soslayar utilizando la implementación de múltiples interfaces que sí está permitida.

2 - En un esquema de herencia, si encuentro que hay funcionalidad común a varios hijos entonces elegiría una Clase Abstracta para implementar la clase padre, dado que las clases abstractas permiten implementar funcionlidad. En cambio , la interfaz por otro lado solo permite definir un contrato de funcionalidad pero no implementarla. Otro factor a tener en cuenta también es que como hablamos en el punto 1. Dado el caso que necesite una "especie" de herencia múltiple entonces podría intentar ir por el lado de interfaces dado que c# nos permite implementar múltiples interfaces y solo una clase abstracta.

3 - En un esquema de modelado de objetos, se considera una relacion de "generalizacion" entre dos clases de modo que se puede decir que la clase B "es un" clase A. Esto se ve típicamente en un modelado de herencia, donde por ejemplo tenemos clase A tipo "Figura" , la clase B (hija de A) tipo "Circulo" , y podemos decir que la Clase "Figura" es una generalizacion de la clase "Circulo". Lo contrario también es cierto : la clase Circulo es una especializacion de la clase Figura.

4 - Dado que en las interfaces solo encontramos declaraciones de cabeceras (firmas) de métodos sin implementar, en una relación de "implementación" lo que encontramos es una clase concreta que implementa todos los métodos definidos en la interfaz respetando el contrato establecido por ésta.

5- Dada una clase A que tiene una relacion de agregación con una clase B: Ssi la clase A deja de existir, la clase B seguirá existiendo independientemente del vínculo que tenían.
Por el contrario, en una relaciòn de composición , donde A está compuesta por B. Si la clase A deja de existir, también lo hará B.

6- a. Verdadero
   b. falso
   c- falso
