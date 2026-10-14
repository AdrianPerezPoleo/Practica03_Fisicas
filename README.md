# Práctica 05. Físicas.
## Introducción
En el siguiente documento se muestran las conclusiones de la experimentación con los diferentes casos propuestos en la primera actividad de la práctica.

## Índice
* [Situación 1](#situación-1)
* [Situación 2](#situación-2)
* [Situación 3](#situación-3)
* [Situación 4](#situación-4)
* [Situación 5](#situación-5)
* [Situación 6](#situación-6)
* [Situación 7](#situación-7)
* [Situación 8](#situación-8)
* [Situación 9](#situación-9)

## Situación 1
### Configuración
Plano (Collider) | Cubo (Rigidbody + Collider) | Esfera (Collider)
### Resultado
![](docs/Introduccion/Introduccion-1.gif)
### Explicación
Dado que, por defecto al crear componentes 3D, ya los objetos tenían cada uno su *collider*, sólo fue necesario agregar el *Rigidbody* al cubo. Como es previsible, dado que la simulación física sólo ocurre en el cubo, no se aprecia movimiento en ninguna de las figuras.

Si se diera el caso de que el cubo está a una altura superior que el plano sí hubiéramos visto como caía, pues el motor simularía la gravedad (conociendo la masa del objeto) y veríamos el desplazamiento. Sin embargo, en la situación presentada, no distinguimos movimiento.

## Situación 2
### Configuración
Plano (Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody + Collider)
### Resultado
![](docs/Introduccion/Introduccion-2.gif)
### Explicación
Este caso es ligeramente diferente al anterior. No solo porque dos objetos cuentan con *Rigidbody* y no uno, sino porque vemos el efecto comentado, la esfera cae llegando a impactar con el cubo y moviéndolo ligeramente.

Esto sucede gracias al motor de simulación de físicas que integra Unity, que en cada *time.FixedTime* va calculando la trayectoria de los objetivos que se mueven por las fuerzas, dándonos una visión realista de lo que sucede.

## Situación 3
### Configuración
Plano (Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody Cinemático + Collider)
### Resultado
![](docs/Introduccion/Introduccion-3.gif)
### Explicación
Esta es la primera situación en la que incluímos un componente cinemático en uno de los objetos. Que un objeto sea cinemático supone que no es incluido dentro de las simulaciones físicas. Es por ese motivo por el que la esfera no cae.

Sin embargo, tiene otras propiedades a la hora de colisionar que podremos aprovechar en momentos futuros de la práctica.

## Situación 4
### Configuración
Plano (Rigidbody + Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody + Collider)
### Resultado
![](docs/Introduccion/Introduccion-4.gif)
### Explicación 
A diferencia de los casos anteriores, en este escenario le hemos añadido un componente *Rigidbody* también al plano. Al no ser un objeto cinemático ni estático, la fuerza de la gravedad actúa sobre él exactamente igual que sobre el resto de las figuras.

Como consecuencia, al iniciar la simulación, el plano cae al vacío arrastrando consigo al cubo y a la esfera. Esto nos demuestra la importancia de mantener como estáticos (o cinemáticos) aquellos elementos del escenario que deben servir como superficie o apoyo fijo.

## Situación 5
### Configuración
Plano (Rigidbody Cinemático + Collider) | Cubo (Rigidbody + Collider, Masa = 1) | Esfera (Rigidbody + Collider, Masa = 10)
### Resultado
![](docs/Introduccion/Introduccion-5.gif)
### Explicación 
Al configurar el plano como cinemático, logramos que actúe como una superficie fija inmune a la gravedad pero capaz de colisionar con otros objetos. Por otro lado, al incrementar la masa de la esfera a 10 unidades (diez veces más que la del cubo), observamos cómo impacta sobre el cubo desplazándolo con más fuerza y rapidez que en la Situación 2.

Esto ocurre porque el motor de físicas aplica principios físicos que dicen que a mayor masa y velocidad de la esfera, mayor es la transferencia de fuerza recibida por el cubo al colisionar.

## Situación 6
### Configuración
Plano (Rigidbody Cinemático + Collider) | Cubo (Rigidbody + Collider, Masa = 1) | Esfera (Rigidbody + Collider, Masa = 100)
### Resultado
![](docs/Introduccion/Introduccion-6.gif)
### Explicación 
En esta situación aumentamos aún más la diferencia de masa, haciendo que la esfera sea 100 veces más pesada que el cubo. El resultado es un impacto que tiene mayor fuerza haciendo que la esfera apenas reduzca su velocidad al chocar y desplace al cubo notablemente.

Vemos así el realismo que tienen las simulaciones físicas, teniendo en cuenta la masa de los objetos en su movimiento.

## Situación 7
### Configuración
Plano (Rigidbody + Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody + Collider con Fricción)
### Resultado
![](docs/Introduccion/Introduccion-7.gif)
### Explicación
En este caso hemos asignado un material físico (*Physics Material*) a la esfera para modificar sus propiedades de fricción. Si hubiera colisión entre la esfera y el cubo o plano, veríamos como el material afecta a la velocidad en la que se desliza la esfera sobre la superficie.

Sin embargo, al tener un plano no cinemático (y con *Rigidbody*), este vuelve a caer por efecto de la gravedad, arrastrando a los objetos.

## Situación 8
### Configuración
Plano (Rigidbody Cinemático + Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody Cinemático + Collider Trigger)
### Resultado
![](docs/Introduccion/Introduccion-8.gif)
### Explicación
Al activar la propiedad *Is Trigger* en el *collider* de la esfera y ser cinemática, esta deja de responder a la gravedad. 

Como resultado, la esfera se queda flotando en el aire y no actúa como un obstáculo físico. Si otro objeto entrara en contacto con ella, la traspasaría por completo. Esto se suele usar para detectar eventos sin alterar la trayectoria física de los objetos.

## Situación 9
### Configuración
Plano (Rigidbody Cinemático + Collider) | Cubo (Rigidbody + Collider) | Esfera (Rigidbody + Collider Trigger)
### Resultado
![](docs/Introduccion/Introduccion-9.gif)
### Explicación
A diferencia de la situación 8, aquí la esfera sí cuenta con un *Rigidbody* dinámico, por lo que la gravedad sí actúa sobre ella y comienza a caer. Sin embargo, al mantener su *collider* marcado como *Is Trigger*, la esfera atraviesa completamente tanto el cubo como el plano cinemático sin colisionar con ellos ni desplazar al cubo.

Esto demuestra que un objeto puede estar sujeto a las fuerzas físicas del motor (como la gravedad) y, al mismo tiempo, comportarse como un área que se puede atravesar.