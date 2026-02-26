# Taller POO Tomás Vélez Duque y Alejandro González David

Bueno profe, si ve que tenemos algunos comits muy cercanos en hora fue porque nos toco crear otro repositorio porque nos fallo una cosa (ésto pasó aproximadamente unas 4 veces).

<img width="603" height="140" alt="image" src="https://github.com/user-attachments/assets/2768286e-d7e8-4ace-9fd3-35f8b09e93f2" />

## Documentación.

<img width="474" height="474" alt="image" src="https://github.com/user-attachments/assets/e2bb3fef-20d4-4f38-9514-913745fff9de" />


Bueno profe, para hacer el proyecto nosotros pensamos en representar a los empleados de manera ordenada. Decidimos crear una clase abstracta Empleado para que todos los empleados compartan la misma info, como el id, nombre o cálculo de salario pero eso depende del tipo de empleado que sea. 

Después nos pusimos a implementar la interfaz (IMostrable) para ver si lo de los empleados si mostraba la info. 

Luego creamos las clases hijas de Empleado, EmpleadoTiempo Completo y EmpleadoPorHoras, que cada una calcula su respectivo salario. Además le metimos sobrecarga al EmpleadoPorHoras para calcularle el salario con bono. Y mientras lo haciamos tratamos de encapsular los atributos con propiedades oara que los datos tengan un acceso regulado. 

Ya pa lo ultimo, le metimos polimorfismo porque los empleados estan en una sola lista, eso nos deja mirarlos sin que nos importe su tipo.

Decidimos declarar el id y el nombre como privados para proteger la información del empleado y que otra parte del programa no los cambie o modifique la info y cause errores.

Las clases y métodos son públicos para que el programa principal pueda crear los empleados y mostrar su información. Si fueran privados, no se podrían usar fuera de la clase.

Algunos atributos específicos de cada empleado como el salario o las horas se declararon como privados, porque solo deberían de ser usados dentro de su propia clase, para que con el encapsulamiento podamos controlar el acceso únicamente de forma controlada

Ya en el main, pusimos la lista para guardar todos los empleados en una sola estructura, que guarda cualquier objeto que herede de la clase Empleado, como los empleados de tiempo completo o por horas, ya con el add se agrego y pusimos el for con el count que indica cuántos elementos hay para que se pueda mostrar la información de cada empleado, ya con esto si se agrega un tercer tipo de empleado es más fácil. 



