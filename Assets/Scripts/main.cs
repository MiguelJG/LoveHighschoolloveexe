﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour {
    public class C
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Hey , que , que haces aquí. No deberías estar por los pasillos,¿Acaso eres el nuevo?\n";
			a.text = "Si no se de que te extrañas.";
			b.text = "A ti que te importa";
			c.text = "Si, ando un poco perdido";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Siendo así no me extraña. Pues… “Bienvenido al instituto” Espero que programemos mucho juntos";
			a.text = "No se yo, a mi me van mas los lenguajes de scripting";
			b.text = "Por supuesto. Los retos moderados son mis favoritos";
			c.text = "No estoy seguro, yo necesito un poco de clase";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "A bueno, eso es otra cosa. A mi el scripting no me va mucho, pero si me lo pides te podría llevar a muchas bibliotecas públicas muy guays ^^";
			a.text = "Bueno. Si tantas ganas tienes creo que podría intentarlo";
			b.text = "Qué pesada. No quiero algo tan complejo";
			c.text = "¿Es que no sabes decir otra cosa?";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Retos moderados. Se que parezco fácil pero espera un poco y verás… jeje";
			a.text = "Tan difícil eres?";
			b.text = "Seguro que no. Un par de clases de informática básica y fijo que aprendo a buscar el mínimo.";
			c.text = "Eso es por lo vieja que eres. Mejor algo más joven";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Jo. Entonces te puedo presentar a algunos de mis familiares";
			a.text = "Me han dicho que c++ también está por aquí?\n";
			b.text = "Tal vez c#?\n";
			c.text = "Por aquí hay mucha gente interesante";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "BIEEEEEEN!!! Creo que para empezar con algo facil deberias practicar con la entrada y la salida, que siempre da problemas";
			a.text = "Claro! Seguire tus consejos al pie de la letra";
			b.text = "Prefiero empezar por los bucles que son más entretenidos";
			c.text = "Tal vez mañana nos vemos. Hasta entonces return 0;";
            cor++;

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No pensaba que fueras a ser tan estúpido. Seguro que eres de los que programan solo con scratch";
			a.text = "Y a mucha honra";
			b.text = "Vete ya a solucionar alguna excepción y déjame en paz";
			c.text = "Que ya te lo dije. Prefiero los de scripting";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Nunca pensé que me encontrara a alguien tan desagradecido. No mereces ser programador";
			a.text = "Todo era mejor con solo circuitos no programables";
			b.text = "Pues vete a Stack Overflow que eso está lleno";
			c.text = "¯\\_(ツ)_/¯";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Al principio no, pero tengo una curva de dificultad peor que la del dark souls";
			a.text = " Acepto el reto";
			b.text = "pfff a lo mejor me lo tengo que pensar";
			c.text = "Venga va. Que no se diga que no se intenta";
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Jajajajajajajaj o tal vez ni eso";
			a.text = "Que si, ya verás";
			b.text = "Te apuesto lo que quieras a que te hago un juego";
			c.text = "Si me ayudas claro que lo conseguiré";
        }
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c, ref int cor)
		{
			texto.text = "Hey!! Que solo tengo 45 años";
			a.text = "Lo dicho. Vieja";
			b.text = "Tus descendientes más jóvenes van mejor que tu";
			c.text = "Comparado con migo, un millenial, eres vieja";
		}

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Si. Probablemente la encuentres en los pasillos. Siempre con objetos en la cabeza";
			a.text = "Pues tal vez me pase mañana";
			b.text = "Seguro que eres mejor.";
			c.text = "Mañana será otro día";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Que va. Es una hikikomori del .NET. Y su padre Microsoft se enfada mucho siempre";
			a.text = "Entonces me alegro de que no esté en este instituto";
			b.text = "Pues me quedo contigo";
			c.text = "Que gente mas rara hay en el mundo";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Por supuesto. Aquí estamos las mejores (Menos PHP. Esa no le gusta a nadie)";
			a.text = "Pues habrá que saludar";
			b.text = "Ya me las iré encontrando";
			c.text = "Pues bueno. Hasta mañana";
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Hey ayuda por favor;";
			a.text = "Qué te pasa?";
			b.text = "Pasando";
			c.text = "Aviso a alguien??";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Creo que voy a tener un error. No se que puede ser";
			a.text = "Seguro que es cosa de algún “;” que falta";
			b.text = "Has añadido todas las librerías?";
			c.text = "Seguro que es un fallo lógico";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Si, seguramente. Me ayudas a buscarlo?";
			a.text = "Por supuesto. Entre los 2 y un poco de extreme programming lo encontramos enseguida";
			b.text = "Mejor que te ayude un debugger";
			c.text = "Por esto python mola. No tiene “;”";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Si estoy segura de haberlas añadido";
			a.text = "Y las dependencias están instaladas??";
			b.text = "Tal vez es un problema del SSOO";
			c.text = "Este fallo demuestra lo mal lenguaje que eres";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Si si, es un segmentation. Noooooooo...";
			a.text = "Pero no te desmayes";
			b.text = "Que algoritmo mas mal programado";
			c.text = "Que exagerada";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Muchas gracias. Sin ti no lo habría encontrado <3";
			a.text = "De nada :)";
			b.text = "Nunca está de más ayudar a un amigo";
			c.text = "Siempre que quieras te ayudo";
            cor++;
        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Siempre respondes con ese tono de estúpido";
			a.text = "Será porque lo soy";
			b.text = "Ni que no pudieras encontrarlo tú sola";
			c.text = "No, lo siento. No quería enfadarte";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ya, pero ye tengo algo que python no tiene...";
			a.text = "Carisma";
			b.text = "Python te puede usar cuando quiera";
			c.text = "Me jor te incluyo en una librería y me voy con c++";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Por supuesto. Que me tomas por una novata ??";
			a.text = "Que humos tan subidos.";
			b.text = "HTML no falla así...";
			c.text = "jajajaja con esa actitud claro que tienes errores";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No creo. Voy en linux que apenas falla";
			a.text = "Yo soy más de Windows";
			b.text = "Teniendo en cuenta que se te puede usar en cualquier sitio...";
			c.text = "apel al poderrrr ";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "no es verdad :’(";
			a.text = "Claro que si";
			b.text = "Paso de ti";
			c.text = "Otros lenguajes son  capaces de omitir esos fallos";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "...";
			a.text = "Te has quedado colgada del todo XD";
			b.text = "Nunca había visto un programa tan colgado";
			c.text = "Que fallo. Seguro que algún contador ha desbordado un vector o algo";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Te puedo hacer una pregunta";
			a.text = "Claro";
			b.text = "Diga lo que diga me la vas a hacer ";
			c.text = "No";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues ahí va :Tu que prefieres ++dummy o dummy++?";
			a.text = "Todo el mundo sabe que hacen cosas diferentes";
			b.text = "Prefiero ++dummy";
			c.text = "Prefiero dummy++";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Eso ya lo se. Eres un poco antipático";
			a.text = "Es que si haces preguntas de primero de carrera pues claro...";
			b.text = "No era mi intención";
			c.text = "Estoy seguro que como ser supremo de la luz, tengo razón";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Se ve que sabes lo que es bueno de verdad";
			a.text = "Ya, yo no quiero para nada una copia del objeto";
			b.text = "Aunque en verdad, las pequeñas diferencias no me molestan";
			c.text = "Nunca pensé que me pondría de acuerdo contigo";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ese no me llega a convencer";
			a.text = "Es el que usa la mayoría de gente";
			b.text = "Pues eso";
			c.text = "Para gustos colores";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues para que te pongas así me voy";
			a.text = "pues vale";
			b.text = "...";
			c.text = "Me da igual";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Vale vale, pues entonces cuál es tu favorita?";
			a.text = "dummy++";
            b.text = "++dummy";
			c.text = "soy un ser del caos y uso dummy +=1";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues te quedas solo, ser supremo de la luz";
			a.text = "Esa era mi intención";
            b.text = "Bien";
			c.text = "Vete a compilar a otra parte";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Sabes la diferencia!!! Eres el mejor";
			a.text = "<3";
			b.text = "Ya lo sabia jeje";
			c.text = "No hace falta que lo digas";
            cor++;
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues a mi un poco :/";
			a.text = " No me importa tu opinión";
			b.text = "Este juego esta como mal programado ¿No?";
			c.text = "Hasta otro dia, pues";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Tengo un +10 en carisma siempre";
			a.text = "Hey que esto no es d&d";
			b.text = "Que chula";
			c.text = "jajajaj claro. Hasta otro dia";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ya, y eso no me gusta";
			a.text = "Pues habrá que explicarles las diferencias";
			b.text = "jajajajaja, me da igual";
			c.text = "otro dia me cuentas el porqué";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Si has llegado aquí te has encontrado con mi falta de inspiración";
			a.text = "No se que poner aqui";
			b.text = "Hacer diálogos es más difícil que programar";
			c.text = "-Ninguna de estas opciones es la valida";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "O mejor dicho, estilos de programación";
			a.text = "Jajajaja";
			b.text = "No tiene tanta gracia";
			c.text = "Que humor más simple";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ya has hecho mi hello world?";
			a.text = "Todo el mundo sabe que el hello world se copia y pega;";
			b.text = " jajajaja claro;\n";
			c.text = "Si, y hasta me resulto dificil";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues creo que va siendo hora de pasar a cosas más complejas";
			a.text = "Mientras no programemos lenguajes operativos";
			b.text = "Por supuesto";
			c.text = "No quiero hacer cosas tan difíciles contigo";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Jo, pues esa era mi intención";
			a.text = "Ves, si es que te leo la mente";
			b.text = "eres demasiado compleja";
			c.text = "pssss";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues te voy a recomendar la librería Darknet de redes neuronales";
			a.text = "Wow, frena el carro, que no soy de computación";
			b.text = "Mola mola, ahora mismo me pongo a aprenderla";
			c.text = "Ya si eso otro dia";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Wow para el carro. Que no nos podemos pasar de pegi 7 que nos echan la bronca";
			a.text = "pfff creo que todos somos adultos aquí";
			b.text = "ni que nos escandalizamos por hablar de ciertos temas";
			c.text = "Hablar de eso vende mas fijo";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "jajajajaja coincidencia";
			a.text = "Lo dicho, no hay ganas";
			b.text = "Mejor otro dia";
			c.text = "Adios";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ya lo se, pero hago lo que puedo";
			a.text = "Se te quiere igual";
			b.text = "Hasta otro dia";
			c.text = "Adios";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "pssss a ti";
			a.text = "pasando";
            b.text = "...";
            c.text = "ja";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No necesitas ser de computación para entenderlo";
			a.text = "Bueno bueno, aunque lo digas así, no";
			b.text = "Pasando";
			c.text = "Déjame en paz anda";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Genial, ya me irás contando que tal :)";
			a.text = "Por supuesto";
			b.text = "Mañana mismo te lo digo";
			c.text = "claro";
            cor++;
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Jo, vale";
			a.text = "Si es que no sabes recomendar nada bueno";
			b.text = "Hasta nunca";
			c.text = "Adios";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ya , pero no es cosa mía, es cosa de la organización";
			a.text = "Pues a ver si el año que viene hacemos un juego muy gore";
			b.text = "Cuando te dicen que no hagas algo siempre tienta";
			c.text = "pasando";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues aparentemente sí, y hay que mantener las formas";
			a.text = "Que ganitas de decir lo que apetezca";
			b.text = "De momento no hemos hecho nada que nos pueda descalificar";
			c.text = "XD";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Claro que vende más";
			a.text = "Que pena que esto no se venda";
			b.text = "Ya lo dice el refrán...";
			c.text = "Este juego es Family friendly";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Eres capaz de decir algun programa que yo he hecho";
			a.text = "Sip";
            b.text = "Nop";
            c.text = "Claro";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Venga, te voy a dar una oportunidad. Elige sabiamente GIT, Unity, Twitter ";
			a.text = "GIT";
			b.text = "Unity";
			c.text = "Twitter";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Exacto. Has acertado. Se nota que sabes sobre mi";
			a.text = "“Son muchos años estudiando ya";
			b.text = "Como no iba  a saber eso sobre el mejor lenguaje del mundo";
			c.text = "Obviamente";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues no. unity lo hace c++ (aunque seguro que me usa para ello)";
			a.text = "si es que c++ es mejor";
			b.text = "No se ni porque estoy hablando contigo";
			c.text = "Es que se nota donde hay clase";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Ni de cerca";
			a.text = "He fallado adrede";
			b.text = "Como que no";
			c.text = "Que pena";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Jajajajajaja me alegro";
			a.text = ":)";
			b.text = "yo también";
			c.text = "psss";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "vas a hacer que me sonroje";
			a.text = "<3";
			b.text = "Cualquier piropo se queda corto";
			c.text = "Si es que eres la mejor";
            cor++;

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = " no es tan obvio. Hay mucha gente que falla";
			a.text = "Me da igual";
			b.text = "Curioso que  fallen";
			c.text = "jajajajajaja";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Eso no es cierto :’(";
			a.text = "si que lo es";
			b.text = "jajajajaja me da igual que llores";
			c.text = "adios";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "ara que te pongas borde me voy";
			a.text = "pues adiós";
            b.text = "...";
			c.text = "era solo una broma";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No tener clases no es malo. Solo soy de otro paradigma de programación";
			a.text = "sin clases no hay gloria";
			b.text = "meh";
			c.text = "Molaria que instanciaras un objeto. A no, que no puedes";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No te creo. Has fallado de verdad";
			a.text = "si :S";
			b.text = "lo que tu digas";
            c.text = "Adios";
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "pues que no está hecho en c. ¡¡Si es que es de navegador!!";
			a.text = "tal vez estas confundida...\n";
			b.text = "Ni me acerque a la respuesta correcta";
			c.text = "Adios";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues si. Te quedas sin el regalo";
			a.text = "¿Cómo, había un regalo?";
			b.text = "jo :(";
			c.text = "Pues me las tendré que apañar sin el";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Qué decir. Se acaba la semana y no nos volveremos a ver hasta la semana que viene";
			a.text = "Tambien me pone triste";
			b.text = "me da igual";
			c.text = "Diga lo que diga vamos a ir a la misma opción";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues eso. hagamos una cosa. Programemos un último programa";
			a.text = "No";
			b.text = "Si claro";
			c.text = "No creo que pueda";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "¿Porque no?¿no te gusto?";
			a.text = "te he dicho muchas veces que no";
			b.text = "jajajajaja ¿tu?";
			c.text = "no estoy seguro";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues vamos a ello. Elige tu el reto:";
			a.text = "Bubble sort";
			b.text = "IA";
			c.text = "Sudoku";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "pues si no estas seguro vete a un lenguaje más fácil. A no que no puedes";
			a.text = "A veces pienso que tu personaje está mal enfocado";
			b.text = "Originalidad o mala programación";
			c.text = "Que es que no te queda originalidad?";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No tiene que ser tan maleducado";
			a.text = "yo hago lo que quiero";
			b.text = "acaso no estoy jugando yo";
			c.text = "adios";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = ":’(";
			a.text = "Adios";
			b.text = "Eso vete a llorar a tu casa";
			c.text = "Me da igual que llores";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Pues si no estas seguro, mejor lo hablamos en otra run";
			a.text = "claro. Este juego es genial y lo voy a rejugar";
			b.text = "Claro, no hay juego mejor que este";
			c.text = "Claro, Este juego gana fijo";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Curiosa elección, vamos a ello";
			a.text = "vamos";
			b.text = "Lo hacemos el fin de semana";
			c.text = "Adios";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Un tema interesante, se ve que te van los retos";
			a.text = "No hay reto que se me resista";
			b.text = "Es que me va eso de crear IAs";
			c.text = "Es que mola";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "La vieja confiable. Me gusta tu estilo";
			a.text = "jej :)";
			b.text = "claro, hasta la próxima";
			c.text = "Si es que molas tu y todo lo que hagas";
            cor++;
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "pues claro que no lo está. Me escribieron a la 1:30 de la noche";
			a.text = "jajajaja no dormir afecta al guionista";
			b.text = "pues hasta nunca";
			c.text = "Adios";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "Definitivamente mala programación";
			a.text = "Si es que eso de hacer un juego en poco tiempo no sale bien";
			b.text = "No saber de unity previamente tiene esos inconvenientes";
			c.text = "XD";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c, ref int cor)
        {
			texto.text = "No es a mi, sino al tío que me escribió";
			a.text = "Se nota que no se le ocurre nada gracioso";
			b.text = "Si es que es un cacas";
			c.text = "Decir caca vulnera el Pegi7?";
        }
    }

    public class Ensamblador
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Aun no es la hora de Educacion Fisica, ¿que haces en la cancha?";
            a.text = "Dar una vuelta, la clase me aburria.";
            b.text = "Te podria preguntar lo mismo.";
            c.text = "Sali al baño y me perdi.";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, ya que estas aqui, ¿Por que no jugamos un rato?";
            a.text = "Por que no.";
            b.text = "¿Estas seguro? Pertenezco a la generacion de los milagros.";
            c.text = "Yo soy mas de estar en mi casa jugando a otomes.";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No tienes muchas ganas de jugar";
            a.text = "No estoy muy animado.";
            b.text = "Es que no me apetece jugar contigo.";
            c.text = "No se jugar.";


        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya chuleria llevas encima, vamos a ver si lo demuestras";
            a.text = "Despues no digas que no te lo adverti.";
            b.text = "Primero debemos calentarnos.";
            c.text = "Here we go!";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que aburrido eres, ¿nunca haces deporte?";
            a.text = "Nop.";
            b.text = "Aveces, cuando me dicen mis amigos de jugar.";
            c.text = "Voy al gimnsaio para mantenerme.";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y eso por que? ¿No te encuentras bien?";
            a.text = "No mucho, me duele la cabeza.";
            b.text = "Ultimamente no estoy animado con nada.";
            c.text = "Simplemente no me apetece.";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eres un borde, no me apetece hablar mas contigo";
            a.text = "...";
            b.text = "...";
            c.text = "...";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No te preocupes, yo te puedo enseñar";
            a.text = "Mejor no, ahora mismo me siento mal";
            b.text = "Venga va";
            c.text = "Se amable conmigo sempai!";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya, menudo partido. No me lo has puesto nada facil. Pero todo el mundo sabe que soy dificil de dominar";
            a.text = "Un placer jugar contigo.";
            b.text = "Tu dame tiempo y te acabaras arrodillando antes mi";
            c.text = "Por eso mismo nadie te quiere, eres un duro.";
            cor++;
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Es eso una proposicion indicente?";
            a.text = "Sera lo que tu quieras que sea <3";
            b.text = "¿Como va a ser nada? No quiero lesionarme";
            c.text = "Puede...";
            cor++;
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y por que no?";
            a.text = "No me gusta sudar.";
            b.text = "Por que me gusta mas ejercitar el cerebro.";
            c.text = "Pues por pereza sin mas";
            cor--;
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues propon tu el ir a jugar";
            a.text = "Deberia hacer eso";
            b.text = "Vivo lejos y no tengo medio de transporte";
            c.text = "Todos estamos muy ocupados";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Como debe ser";
            a.text = "Todos deberian hacer lo mismo";
            b.text = "Estoy mal de la espalda y debo mantenerme";
            c.text = "Por cada vez que un codigo no compila hago 5 dominadas";
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Sabes a que hora empieza la clase?";
            a.text = "Ni idea, lo siento";
            b.text = "Dentro de una hora";
            c.text = "En un rato, supongo";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que te apetece mientras esperamos?";
            a.text = "Me pondre a programar";
            b.text = "¿Te apetece jugar al fútbol?";
            c.text = "¿Jugamos al Ajedrez?";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que lenguaje usas?";
            a.text = "No creo que lo conozcas.";
            b.text = "Uno muy viejo, no tengo registros de cuando es.";
            c.text = "C++ ya que tengo clase.";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Mejor a otra cosa, que soy mas lento que un sumador sin acumulador";
            a.text = "Venga tranquilo, no te haré moverte mucho.";
            b.text = "Que aburrido eres.";
            c.text = "Pues entonces juguemos a los registros.";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Como se juega a eso?";
            a.text = "Yo te explico.";
            b.text = "Mejor pideselo a alguien con mayor abstranción.";
            c.text = "Que pocas registros tienes....";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Podrias probar, soy el padre de los lenguajes.";
            a.text = "Que chistoso eres...";
            b.text = "Entonces me podras enseñar ";
            c.text = "Y conoces a Python, me encanta, es tan facil de interpretar.";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Yo tengo hasta 32 registros!!";
            a.text = "¿Te estas haciendo el chulo?";
            b.text = "Me importa zero";
            c.text = "Ya pero no todos se pueden usar";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que glamuroso eres";
            a.text = "Yo solo uso de lo bueno lo mejor de lo mejor lo superior";
            b.text = "Pues yo creo que sus punteros son lo peor";
            c.text = "Su metodologia me gusta.";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale...Hare lo que pueda.";
            a.text = "Asi se habla.";
            b.text = "Gambare! Ensamblador-sempai.";
            c.text = "No te dare mucha caña.";
            cor++;
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Normalmente me llaman tedioso...";
            a.text = "Pero sin ti no podriamos hacer nada";
            b.text = "No les hagas caso, a mi me gustas";
            c.text = "Un poco.";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Para que sirve el regiustro Zero?";
            a.text = "Solo para poner 0";
            b.text = "Para nada, como tu.";
            c.text = "Ese regustro no existe";
            cor++;
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Lo siento, me cuesta mucho pillar las cosas.";
            a.text = "Mejor dejemoslo.";
            b.text = "Te lo vuelvo a explicar.";
            c.text = "A todos nos pasa.";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero si me enseñas seguro que soy mas optimo que el resto!";
            a.text = "Pero es muy compliado D:";
            b.text = "Otro dia si eso";
            c.text = "Bueno, vamos a intentarlo";
        }



        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "LLegas justo a tiempo, necesito a alguien para que me ayude con un problema.";
            a.text = "¿Que es?";
            b.text = "Vere que puedo hacer";
            c.text = "...";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Necesito equipo de programación";
            a.text = "A mi me gusta trabajar solo.";
            b.text = "Programar en equipo es lo mejor!";
            c.text = "Creo que somos incompatibles";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero en un proyecto siempre trabajan en equipo";
            a.text = "Pero la verdad es que no me apetece trabajar contigo";
            b.text = "Puedo hacer un esfuerzo";
            c.text = "Vale pero solo si no usas Go to que son muy feos";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Asi se habla, tengo que hacer un juego y aun no he empezado. ¿Te apuntas?";
            a.text = "Cuando hay que terminarlo";
            b.text = "A mi me va mas programar a bajo nivel";
            c.text = "Solo si me reconoces en los creditos";
            cor++;

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Siempre eres tan grosero con la gente?";
            a.text = "Solo con las personas que estan en desuso.";
            b.text = "Perdoname pero no me terminas de caer bien.";
            c.text = "...";
            cor--;

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me alegra oir eso, te voy contando de que va la cosa";
            a.text = "Vale!";
            b.text = "Pero despacio que solo trabajo con 32 bits";
            c.text = "Me muero de ganas de trabajar contigo";
            cor++;

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero yo debo usarlos";
            a.text = "Pues estan obsoletos";
            b.text = "No me gustan, pero hare la excepcion contigo";
            c.text = "No pasa nada, ya nos las arreglaremos";
            cor--;

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Puuuuues ese es el problema, es para dentro de una semana";
            a.text = "Una semana da para mucho!";
            b.text = "Ufff, un poco ajustado.";
            c.text = "ESTAS LOCO, no dara tiempo.";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, te puedes ocupar tu de la parte de programacion y yo de la grafica";
            a.text = "Me gusta la idea!";
            b.text = "No lo veo..";
            c.text = "Bueno, lo podemos intentar";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por supuesto!";
            a.text = "Pues manos a la obra!";
            b.text = "Aun tenemos que hablar del trabajo";
            c.text = "";
        }


        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Te apetece hacer algo?";
            a.text = "No";
            b.text = "¿Tienes algo pensado?";
            c.text = "Sorprendeme";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Queria jugar a la Magic pero me falta a alguien";
            a.text = "¿A que?";
            b.text = "No tengo mi mazo aquí, lo siento";
            c.text = "No";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "A un juego de cartas";
            a.text = "Nunca había oído hablar de él";
            b.text = "Pero ne tienes que ir explicando";
            c.text = "Paso";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No pasa nada, yo te presto uno!";
            a.text = "Venga va, esto será más fácil que contar hasta mil";
            b.text = "Veré lo que puedo hacer";
            c.text = "No me gusta tu mazo";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero que te pasa, tu como siempre arisco";
            a.text = "Lo siento, no me terminas de gustar";
            b.text = " Es que no me apetece";
            c.text = "No se que me pasa hoy, siento que no soy yo que me controla";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero si es super famoso";
            a.text = "No me gustan los juegos de cartas";
            b.text = "No estoy puesto en esas cosas";
            c.text = "Yo solo entiendo de programación";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso está hecho!";
            a.text = "Perfecto!";
            b.text = "Espero que expliques bien, y seas claro, no como tu lenguaje";
            c.text = ":D";
            cor++;


        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Por que?";
            a.text = "Porque si";
            b.text = "Psss";
            c.text = "Contigo Pipo";
            cor--;

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "De qué hablas?";
            a.text = "Eres poco interpretativo";
            b.text = "Que poco entiendes";
            c.text = "NULL";
            cor--;
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Seguro que lo haces bien";
            a.text = "Eso espero";
            b.text = "Espero que me ayudes un poco";
            c.text = "Hare lo que pueda";
            cor++;
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Por que dices eso?";
            a.text = "Por que yo soy mas de usar el color azul, me gusta robar codigo...digo cartas";
            b.text = "Por nada";
            c.text = "No me gusta lo que no conozco";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso dicen todos, no le gusto a nadie. Soy difícil de entender";
            a.text = "Es que eres dificil";
            b.text = "Hay otros lenguajes mas sencillos";
            c.text = "En el fondo todos te quieren, te necesitan";
            cor--;
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Haberlo dicho antes, tampoco hay que ponerse así";
            a.text = "La proxima vez sere mas directo";
            b.text = "Lo siento";
            c.text = "Es que no sabia como decirtelo";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Deberías hacértelo mirar";
            a.text = "Debo ir al comecocos";
            b.text = "Paso de ir, solo me esta pasando esta semana";
            c.text = "Me gustaria saber si a alguien mas le pasa";
            cor++;
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "PERDONA! ¿ME PUEDES AYUDAR?";
            a.text = "QUE PASA!";
            b.text = "(No contestar)";
            c.text = "Claro";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Necesito ir a la enfermería y tengo que acabar una práctica";
            a.text = "Lo siento, yo no hago prácticas ajenas";
            b.text = "¿Que tengo que hacer?";
            c.text = "Cuenta con mi Espada!";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Venga hombre no seas así!";
            a.text = "Lo siento, tengo menos sentimientos que tu paradigmas de programación";
            b.text = "Otro día si eso";
            c.text = "Bueno, que tengo que hacer a ver si me convences";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Algo sencillo! Programar el juego de la vida";
            a.text = "Bueno, mientras no lo haga en tu lenguaje...";
            b.text = "Eso es muy complicado";
            c.text = "Eso es sencillo, Lets do this";
            cor++;

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No entiendo...";
            a.text = "ES MIO SOLO MIO MI TESORO";
            b.text = "Nada, frikadas mías";
            c.text = "...";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso es muy cruel";
            a.text = "Tienes que aprender a vivir con ello";
            b.text = "No necesariamente es algo malo";
            c.text = "Lo siento sempai";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Al menos llévame a la enfermería";
            a.text = "Apañatelas como puedas";
            b.text = "Venga te ayudo";
            c.text = "Que remedio";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "De camino a la enfermería te cuento";
            a.text = "Perfecto";
            b.text = "Agarrate a mi";
            c.text = "Vamos";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¡Menuda ofensa a mi persona, soy el mas eficiente!";
            a.text = "Y el mas dificil al mismo tiempo";
            b.text = "Solo si sabes programar bien";
            c.text = "Eso es discutible";
            cor--;
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Yo te explico los algoritmos de camino a la enfermería";
            a.text = "Perfecto";
            b.text = "Agarrate a mi";
            c.text = "Vamos";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Perfecto, sabía que podía confiar en ti";
            a.text = "No tienes que preocuparte de nada";
            b.text = "Vamos que te ayudo";
            c.text = "Siempre soy confiable";
            cor++; cor++;
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "De verdad que no te entiendo";
            a.text = "Ni yo me entiendo aveces";
            b.text = "Me suelen decir eso";
            c.text = "Suele pasar";
            cor--;
        }



        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Llévame a la enfermería anda…";
            a.text = "No quiero";
            b.text = "Creo que no tengo mas remedio";
            c.text = "Venga anda";
            cor--;
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Cuanto tiempo!";
            a.text = "Pero si nos vimos ayer";
            b.text = "De que hablas";
            c.text = "Ey!";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y que haces en el Insti un sabado?";
            a.text = "Tengo actividades de club";
            b.text = "Daba una vuelta";
            c.text = "Venia a recoger unos libros";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿En que club estas?";
            a.text = "En el club de programación de riesgo";
            b.text = "En el club romano";
            c.text = "En el club de programacion orientada a objetos";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y te pasas por la cancha? Esto parece una señal del destino";
            a.text = "No te hagas ilusiones";
            b.text = "Nadie sabe lo que nos depara el destino";
            c.text = "Yo solon creo en el monstruo del espagueti volador";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que aplicado, ¿te apetece hacer algo de ir a por los libros?";
            a.text = "Tu diras";
            b.text = "¿Y en que estabas pensando?";
            c.text = "Creo que paso, me voy directo a por mis libros";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Como que de riesgo?";
            a.text = "Lo dejamos todo para ultimo momento y no sabemos si llegaremos a tiempo(Como este juego)";
            b.text = "Cosas de programadores";
            c.text = "No lo entenderias";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que es el club romano?";
            a.text = "Una tonteria de club";
            b.text = "Un club donde no se hace nada";
            c.text = "Nada interesante";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Entonces C++ es la jefa?";
            a.text = "Asi es!";
            b.text = "Es muy mandona pero si";
            c.text = "¿Como lo supiste?";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Lo decia por decir";
            a.text = "A bueno!, ya creia que querias algo";
            b.text = "Ya bueno, me alegra tenerte como amigo";
            c.text = "Entendi lo que querias decir, tranquilo";
            cor++;
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tienes razon, nos podriamos poner filosoficos";
            a.text = "Una pena que no me guste nada la filosofia";
            b.text = "Algun dia";
            c.text = "La filosofia es inutil";
            cor++;
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que es eso?";
            a.text = "La mejor religión";
            b.text = "Una payasada de los americanos";
            c.text = "Una cosa que me acabo de inventar";
            cor--;
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vamos a jugar al baloncesto!";
            a.text = "Venga un 32! Jajaja como tus registros";
            b.text = "Mejor a otra cosa";
            c.text = "Seguro que gano";
            cor++;
        }



        public void actualizar_dia6133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Como siempre, aburrido";
            a.text = "Tengo muchas cosas que hacer";
            b.text = "Otro dia si eso";
            c.text = "No me digas eso!";
            cor--;
        }
    }

    public class Python
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "print(“Hola, tu debes de ser el nuevo”)";
            a.text = "Si";
            b.text = "Hola.";
            c.text = "Se ve que pillas los detalles";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Espero que aprendas mucho en este instituto. (Sobre todo a como indentar bien codigo jejeje)";
            a.text = "Indentar el código es de débiles. Yo lo hago todo en una línea";
            b.text = " “Codigo indentado” == “Alma en paz”";
            c.text = "Me centro más en lo que programo que en cómo lo hago";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se ve que vas por ahi de duro";
            a.text = "No lo voy, lo soy";
            b.text = "No no, era broma";
            c.text = "Y a ti qué más te da";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Efectivamente, esa es una gran filosofía de vida";
            a.text = "Y ademas hay ciertos lenguajes que necesitan estar bien indentados….";
            b.text = "La mejor sin dudarlo";
            c.text = "Eso si, depende de quien lo haga puede llegar a verse feo";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues seguro que estéticamente es feo";
            a.text = "Eso da igual";
            b.text = "Estas diciendo que programo mal!!!??";
            c.text = "Cada cual con su estilo";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues no creo que dures mucho aquí, señor duro";
            a.text = "Paso de ti";
            b.text = "No te creas";
            c.text = "jajajajajaja";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, si es asi seguro que tarde o temprano nos llevamos bien";
            a.text = "Jajajaja te lo creíste";
            b.text = "Si claro";
            c.text = "Puede";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues que como delegada me tengo que asegurar que todos los alumnos son decentes";
            a.text = "Me da igual eso";
            b.text = "Que ocupación más chorra";
            c.text = "Los delegados no son necesarios";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "O-O se ve que sabes mis secretos. jajajaja me caes bien";
            a.text = "Es que a quien no le voya a caer bien";
            b.text = "Tu me caes bien a mi";
            c.text = ":)";
            cor++;
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tal vez en un futuro nos podremos llevar bien";
            a.text = "Claro";
            b.text = "Mañana mismo por ejemplo";
            c.text = "El futuro siempre es insondable como mi alma";
        }
        public void actualizar_dia1123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por supuesto, como esa odiosa gente que deja muchas lineas en blanco, o abre los corchetes en la linea de debajo de la funcion";
            a.text = "No te puedo llevar la contraria en eso";
            b.text = "Llevas toda la razon";
            c.text = "Esa es la unica verdad";
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Un buen código no es aquel que puede leer una máquina, sino el que puede entender un humano";
            a.text = "Que profundo, pero me da igual";
            b.text = "Dices cosas muy raras";
            c.text = "eres muy rara";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Mal mal, no. Bueno si, programar feo es programar mal";
            a.text = "Tienes razón, intentaré cambiar";
            b.text = "Es duro cambiar, pero no te puedo llevar la contraria en esto";
            c.text = "Pasando";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, es recomendable tener un estilo generico en plan el de google o microsoft en vez de uno propio to’feo";
            a.text = "Tal vez tengas razon";
            b.text = "No sabes lo que dices";
            c.text = "Pasando"; //Cambiarlo, no me convence
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Parece que me has seleccionado para tu segundo dia!";
            a.text = "Por supuesto";
            b.text = "No, me he equivocado";
            c.text = "Me he equivocado, pero vale";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, sea como sea ahora estás aqui";
            a.text = "Que desgracia";
            b.text = "Me alegro por ello";
            c.text = "Menos da una piedra";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No le pienses asi, piensalo mejor como una oportunidad";
            a.text = "Oportunidad para que";
            b.text = "pasando";
            c.text = "Siempre eres asi";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Siempre me gusta conocer a gente con tantas ganas como yo";
            a.text = "Si es que eres la más útil de todas";
            b.text = "Juntas haríais algo genial";
            c.text = "A ver, que tantas tantas ganas ,no tengo";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ya, pero las piedras no son tan guapas como yo";
            a.text = "No te lo tengas tan creido";
            b.text = "Bueno bueno, eso es discutible";
            c.text = "Lo importante no es la belleza, sino la velocidad a la que interpretas codigo";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No se, aprender algo";
            a.text = "No lo creo";
            b.text = "Ya se todo lo que necesito";
            c.text = "Mejor otro dia";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Cuando tengas que hacer algo facilmente te acordaras que no me aprendiste cuando pudiste";
            a.text = "No lo creo";
            b.text = "Si ese dia llega te daré la razon";
            c.text = "jajajajajajaja no";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si, y no me has visto en todo mi poder. Soy genial manejando excepciones";
            a.text = "Pues maneja esta << Dices mientras se va haciendo un gesto muy obsceno>>";
            b.text = "C++ maneja mejor las exepciones";
            c.text = "Paso de ti";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ya lo se, no hace falta que lo digas";
            a.text = "Creo que incluso uno de los programadores de este juego te usó para hacer un poster que está en el congreso";
            b.text = ":)";
            c.text = "Eso es una verdad como un puño";
            cor++;
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si la realidad es que para hacer algo genial nos tienes que dominar a todas";
            a.text = "A ver si lo consigo";
            b.text = "Eso parece una ardua tarea";
            c.text = "Espero tener suerte y seguir clicando de manera aleatoria las opciones correctas";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues entonces no me hagas perder ciclos de cpu y pirate";
            a.text = "Pues me voy";
            b.text = "Si es que eres una simple";
            c.text = "Pasando";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me lo puedo tener creido, que si no fuera por el congreso probablemente estarias solo/a en tu casa sin amigos";
            a.text = "De que vas";
            b.text = "Ahora me has hecho llorar";
            c.text = "Pues creo que yo y mis amigos vamos a darle una paliza al que hizo esto ";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No es discutible. Soy el lenguaje mas elegante de todos";
            a.text = "Eso es hasta que el Go te destrone";
            b.text = "C++ es mucho mas elegante";
            c.text = "yo soy mas de la belleza clásica. ensamblador y esas cosas";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y eso se me da dpm";
            a.text = "Pero nunca serás tan rapida como uno compilado";
            b.text = "Jajajajajajaja";
            c.text = "Eso hay que testearlo";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Wow, el tercer dia y tu por aqui";
            a.text = "Estoy empezando a pensar que la primera pregunta de todos los dialogos no hace nada";
            b.text = "Claro, como no querer programar contigo";
            c.text = "Paso de ti, me voy a otra parte… <Te vas (se salta el resto del dia)>";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hoy vamos a hacer TDD";
            a.text = "Esto me esta trabando mucho, porque mis decisiones no importan";
            b.text = "Venga va";
            c.text = "¿Y si mejor hacemos otra cosa?";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "JUGADOR SALIENDOSE DE PARÁMETROS, INICIANDO RUTINA DE BLOQUEO";
            a.text = "Que!! no espera, qué es eso?";
            b.text = "No no, ya no quiero jugar a esto, no me van los juegos de miedo :(";
            c.text = "No por favor, ya paro";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "A que hacer las pruebas antes de escribir el codigo es super guay??";
            a.text = "Me gusta, pero no se yo rick, no me convence";
            b.text = "Es muy guay, aunque no tan  guay como hacer unit tests";
            c.text = "Es lo mejor que hay";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que quieres hacer";
            a.text = "Quiero usar tensorflow, que he leído que contigo va genial";
            b.text = "Hagamos una aplicacion para movil";
            c.text = "Mejor algo sencillito, vamos a hacer un miniservidor";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "*****************";
            a.text = "*****************";
            b.text = "*****************";
            c.text = "*****************";

        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "*****************";
            a.text = "**************";
            b.text = "************";
            c.text = "********************************************************socorro**************************************************************";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "*****************";
            a.text = "*****************";
            b.text = "*****************";
            c.text = "*****************";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, hay muchas maneras de hacer test por ahi";
            a.text = "Tantas que marea";
            b.text = "ya lo creo";
            c.text = "jajajajajajajaj";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ambas cosas son guays";
            a.text = "Claro";
            b.text = "No, solo unit testing";
            c.text = "Todos podemos ser felices";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Claro!! <3";
            a.text = "jajajajaja";
            b.text = ":)";
            c.text = "Es casi tan bueno como tus bucles";
            cor++;
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "jajajaja si, venga va";
            a.text = "a ver si asi aprendo algo de IA";
            b.text = "Espero que no sea muy dificil";
            c.text = "A ver que sale";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues de todo lo que hago, eso no se me da muy bien. Mejor una aplicación web";
            a.text = "Meh, yo paso de la web";
            b.text = "Si no puedes hacer eso, pierdes un mercado muy grande";
            c.text = "Pues si tu no puedes, me buscaré a alguien que si pueda";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso lo puedo hacer incluso sin usar casi librerias";
            a.text = "wow, eso es impresionante";
            b.text = "Será facil de hacer , pero seguro que no tan eficiente";
            c.text = "Mejor hago otra cosa";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Wow. Es impresionante que estes ya pasada la mitad del juego. Te voy a hacer un regalo. Tu solo sigue mis instrucciones";
            a.text = "vale";
            b.text = "Los regalos me gustan";
            c.text = "eso siempre mola";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "<-";
            a.text = "<-";
            b.text = "-";
            c.text = "->";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "-";
            a.text = "<-";
            b.text = "-";
            c.text = "->";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "->";
            a.text = "<-";
            b.text = "-";
            c.text = "->";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "->";
            a.text = "<-";
            b.text = "-";
            c.text = "->";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Has tomado el camino mas recto, eso te hace merecedor de mi corazón";
            a.text = "Bieeen";
            b.text = "y ahora que";
            c.text = "Este tipo de regalos me gustan";
            cor++;
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajajajaj, has sido fuertemente troleado por python XD";
            a.text = "-.-";
            b.text = "-.-";
            c.text = "-.-";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ayer fue un dia extraño, pero hoy toca ponerse a programar a tope";
            a.text = "¿Porque raro?";
            b.text = "jajajaja, hoy es un nuevo dia";
            c.text = "Que pesada que eres";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vamos a programar un tres en raya";
            a.text = "Paso, eso es muy fácil";
            b.text = "Y no podemos hacer otra cosa?";
            c.text = "Siiiiii";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si tan facil es , porque no lo haces";
            a.text = "Porque no me apetece";
            b.text = "Que dialogo mas pobre";
            c.text = "Que falta de creatividad";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale, que quieres hacer";
            a.text = "Un sudoku";
            b.text = "procrastinar";
            c.text = "Una calculadora de lenguajes normales de chomsky que además luego genere una máquina de turing capaz de analizar el mismo lenguaje de chomsky";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es algo bastante facil, pero creo que será un reto mas que suficiente para entretenerte un par de horas";
            a.text = "Con lo bien diseñada que estas, lo acabo en menos de 10 min";
            b.text = "Gracias a mi intelecto superior lo acabaré en un periquete";
            c.text = "Y si no, siempre puedo venir otro dia y hacerlo";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "jaajajajajajaa. Creo que compartes el mismo sentimiento que el programador al hacer este guión. Lo puedes ver en esta imagen y sentirte reflejado https://goo.gl/PdThMW";
            a.text = "XD";
            b.text = ":’(";
            c.text = "paso de copiar el link a mano";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "jaajajajajajaa. Creo que compartes el mismo sentimiento que el programador al hacer este guión. Lo puedes ver en esta imagen y sentirte reflejado https://goo.gl/PdThMW";
            a.text = "XD";
            b.text = ":’(";
            c.text = "paso de copiar el link a mano";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "jaajajajajajaa. Creo que compartes el mismo sentimiento que el programador al hacer este guión. Lo puedes ver en esta imagen y sentirte reflejado https://goo.gl/PdThMW";
            a.text = "XD";
            b.text = ":’(";
            c.text = "paso de copiar el link a mano";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, eso es mas difícil que el tres en raya, pero me vale";
            a.text = "Claro que te vale";
            b.text = "Como no te va a valer";
            c.text = "Cualquier cosa que programe yo va a ser buena";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "La pereza es la madre de todos los vicios. Y como una madre hay que respetarla";
            a.text = "...";
            b.text = "...";
            c.text = "...";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hey, no me intentes usar para que te haga las practicas de computabilidad y algoritmia";
            a.text = "Era para ver si colaba";
            b.text = "jajajajaa, me has pillado";
            c.text = "Eso no es así, las de CyA son en c++ (que es mejor que tu)";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Siempre sabes que decir para que me sonroje… ";
            a.text = "<3";
            b.text = "<3";
            c.text = "<3";
            cor++;
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Wow, que chulo. Eso lo dices porque eres fan de rick y morty fijo";
            a.text = "¿Que es eso?";
            b.text = "jajajajajaja";
            c.text = "No, eso otro meme diferente";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale, todos los dias estoy en el mismo sitio, asi que ya sabes donde encontrarme";
            a.text = "Aqui vendré";
            b.text = "Es un poco raro que siempre estes aqui";
            c.text = "Jajajajaja vale";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jooo ya es el ultimo dia";
            a.text = "Que se le va a hacer";
            b.text = "sip";
            c.text = "Que corto se me ha hecho";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vamos a aprovecharlo para hacer un poco de django (esa gran libreria)";
            a.text = "No me gusta mucho";
            b.text = "No se que es django";
            c.text = "La adoro";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y eso";
            a.text = "Me parece muy monolítico";
            b.text = "Los componentes son desplegados juntos";
            c.text = "Necesitas saber como funciona todo el sistema para hacerlo funcionar";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es una librería que facilita la creación de webs complejas";
            a.text = "Suena alucinante. Y si es una libreria de python, entonces estará realmente bien escrita";
            b.text = "A mi es que las paginas webs no me gustan mucho";
            c.text = "Meh, pasando";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "A que si, algo tan util siempre mola. Que es lo que mas te gusta?";
            a.text = "Su versatilidad";
            b.text = "Su claridad de código";
            c.text = "Que es rápido de escribir";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tienes mucha razón, pero eso no es motivo para no usarlo";
            a.text = "Pasando";
            b.text = "Pues vamos a intentarlo";
            c.text = "Si tu lo dices...";

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ya, eso es un pelin raro, pero te haces a ello";
            a.text = "No creo que pueda";
            b.text = "Pasando";
            c.text = "Podría intentarlo";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ahí te tengo que dar la razón, pero con mi ayuda seguro que lo consigues";
            a.text = "Habrá que intentarlo";
            b.text = "Venga va";
            c.text = "Va a ser que no";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Obviamente <3";
            a.text = "...";
            b.text = "...";
            c.text = "...";
            cor++;
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno. No creo que importe mucho, pero espero que en otra run si decidas aprenderlas :)";
            a.text = "Que respuesta tan pasivo-agresiva";
            b.text = "jajajaja claro";
            c.text = "Hasta la próxima!";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues nada. Aunque no la aprendas me alegro que me seleccionaras la ultima";
            a.text = "Yo tambien me alegro";
            b.text = "Te volveré a ver";
            c.text = "Paso de ti";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ciertamente cierto";
            a.text = "...";
            b.text = "...";
            c.text = "...";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ciertamente cierto";
            a.text = "...";
            b.text = "...";
            c.text = "...";
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ciertamente cierto";
            a.text = "...";
            b.text = "...";
            c.text = "...";
        }

    }

    public class Java
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenas tardes. ¿Que le puedo servir?";
            a.text = "Que sitio mas raro";
            b.text = "Que rapido me atienden aqui";
            c.text = "...";
            

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Espera, yo te conozco… Estamos en la misma clase, ¿Verdad?";
            a.text = "No me suenas";
            b.text = "No lo creo, no salgo mucho de mi habitación";
            c.text = "Puede ser";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por tu uniforme diría que estamos en la misma escuela. Siempre alegra ver gente nueva, aunque ya te digo que me suenas mucho. Me habré confundido, juraría que te he visto en otra parte. En fin, perdona mis modales… !Bienvenido a la cafetería Oracle! ¿Qué te puedo servir?";
            a.text = "Ponme un café de Java";
            b.text = "Cualquiera me sirve";
            c.text = "¿Que me recomiendas?";

        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No pasa nada, yo tambien me suelo quedar mucho tiempo frente a la pantalla. Sobretodo las noches en las que me quedo programando hasta tarde. Es horrible cuando estás atascado en alguna parte del codigo.";
            a.text = "¿Por casualidad frecuentas StackOverflow?";
            b.text = "A veces me pasa, aunque prefiero consultarlo con la almohada";
            c.text = "¿Puedes tomar nota ya? Tengo prisa. Ponme un café";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, eso depende, puedes revisar la carta y te doy mas tiempo si quieres. Aunque algo rápido sería un cafe.";
            a.text = "Vale";
            b.text = "no te preocupes, ponme un cafe de Java";
            c.text = "No me di cuenta de la hora que es, lo siento, me tengo que ir";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya, ese es mi café favorito, lo llevo tomando casi desde que nací. Se ve que mi padre y sus amigos eran unos adictos a él en el trabajo.  Me has caido bien, este lo paga la casa :)";
            a.text = "Cuanta amabilidad";
            b.text = "Oh, no me lo esperaba";
            c.text = "No es mi cumpleaños, ¿verdad?";
            cor++;
        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "marchando, pero luego no te quejes si no es de tu agrado";
            a.text = "Ok";
            b.text = "Mmmm,.. Quizás fui demasiado borde";
            c.text = "No pienso volver a esta cafetería";

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, pues no vuelvas por aqui";
            a.text = "Eso haré";
            b.text = "Ya te vale";
            c.text = "Super amable la camarera";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues claro! a veces es muy útil, Aunque hay veces en las que no entiendo nada… ¡Pero lo importante es que funciona! Veo que me entiendes, acabo mi turno en 10 minutos, te invito a un cafe...";
            a.text = "Perfecto";
            b.text = "Mejor no, gracias";
            c.text = "Esto no me lo esperaba";
            cor++;
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jajaja, me pasa lo mismo, pero otras veces el error está en un simple punto y coma que se te escapa";
            a.text = "No serás tu la mejor programadora del mundo, ¿no?";
            b.text = "Lo que hay que escuchar";
            c.text = "Si utilizaras un IDE eso no te pasaría";
        }
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c, ref int cor)//añadir
		{
			texto.text = " Vale vale, tranquilo, enseguida te lo traigo... ";
			a.text = "Rapidito";
			b.text = "Ya se me escapó la guagua";
			c.text = "No voy a llegar a tiempo ";
		}

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Avísame si necesitas algo, estaré por aqui";
            a.text = "Estupendo";
            b.text = "Vale pero no te vayas muy lejos";
            c.text = "No me convence la carta";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya, ese es mi café favorito, lo llevo tomando casi desde que nací. Se ve que mi padre y sus amigos eran unos adictos a él en el trabajo.  Me has caido bien, este lo paga la casa :)";
            a.text = "Cuanta amabilidad";
            b.text = "Oh, no me lo esperaba";
            c.text = "No es mi cumpleaños, ¿verdad?";
            cor++;
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No pasa nada, ¡vuelve pronto!";
            a.text = "Me lo pensaré";
            b.text = "Si si, volveré, no te preocupes";
            c.text = "Chacho, que pesada loco"; //Cambiarlo, no me convence
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenos días ¿Que le puedo servir?";
            a.text = "(Quedarse callado)";
            b.text = "Buenos días";
            c.text = "Observar la mesa de al lado";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Un momento ¿Usted no estuvo ayer aquí?";
            a.text = "Vengo por el famoso café";
            b.text = "¿Me toma nota? Por favor";
            c.text = "Realmente no sé que hago aquí ";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No me sorprende, Java es una maravilla para el paladar y lo servimos de una manera muy especial";
            a.text = "Lo es, realmente me llama mucho la atención. ¿Me podrías decir el secreto?";
            b.text = "A ver, está bien, pero tampoco es una maravilla";
            c.text = "Cuanta modestia";
            cor++;
        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale vale, ¿Que te apetece tomar?";
            a.text = "Ponme un barraquito ";
            b.text = "Un sanwich mixto";
            c.text = "No me convence la carta";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "En el fondo sé que estás aquí por nuestro increíble café de Java";
            a.text = "Ponme uno de esos entonces";
            b.text = "No sé, no me terminas de convencer";
            c.text = "En realidad es porque me queda al lado de las clases";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ni de broma. Es un secreto que solo mi familia conoce y no lo voy a revelar así por las buenas ";
            a.text = "Como quieras";
            b.text = "Ni que fuese la receta de la cocacola";
            c.text = "Pues me voy";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Cómo dices?";
            a.text = "Lo que oyes";
            b.text = "He probado elixires mejores";
            c.text = "No te ofendas";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Siempre digo lo mismo pero Java es el café favorito de mi padre. Lo solía tomar con sus amigos en el trabajo";
            a.text = "Interesante";
            b.text = "¿En serio? ¡Que guay!";
            c.text = "Tampoco me cuentes tu vida";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Un barraquito? ¿Que es eso? Yo te recomendaría un café de Java, es más rápido";
            a.text = "Me fio de tus gustos, sírveme uno";
            b.text = "Me gusta mas el barraquito";
            c.text = "No me vendas la moto";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y… ¿No lo quieres acompañar con un café de Java?";
            a.text = "Eso estaría genial";
            b.text = "No, gracias";
            c.text = "Parece que Java y tu sois uno";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Te dejo más tiempo para decidir";
            a.text = "Perfecto";
            b.text = "(Seguir ojeando la carta)";
            c.text = "Tu verás lo que haces";
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¡Marchando! No te arrepentirás, vas a probar el mejor café del mundo";
            a.text = "Pones las expectativas muy altas";
            b.text = "Como para que no me guste";
            c.text = "Que ganas de probarlo";
            cor++;
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Entonces deberías probarlo. Juro que no te arrepentirás";
            a.text = "Como no me guste lo pagas tu";
            b.text = "Es difícil que no me guste con ese nombre";
            c.text = "Paso";
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jo, eres peor que un segmentation fault";
            a.text = "Me lo suelen decir";
            b.text = "Es lo que hay";
            c.text = "(Sonreir)";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hoy es nuestro visitante Nº100, le vamos a dejar elegir cualquier cosa de la carta de forma totalmente gratuita";
            a.text = "¿Que me estas comentando?";
            b.text = "Esto es mejor que compilar a la primera";
            c.text = "¿De qué me sonará esto?...";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si si, lo que escuchas. Además es la primera vez que hacemos algo así, espero que la carta sea de tu agrado ";
            a.text = "Ponme de todo";
            b.text = "Ponme un Cafe de Java";
            c.text = "Esto me huele mal, no quiero nada, me voy";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso son pequeños placeres de la vida reservados a unos pocos afortunados. Entonces ¿Que te sirvo?";
            a.text = "Ponme un cafe de Java";
            b.text = "Ponme de todo";
            c.text = "Ponme un barraquito";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es algo similar a los anuncios de internet, pero con la diferencia de que aquí no te ponemos keylogers ni programas basura y somos más confiables";
            a.text = "Se ve que entiendes mucho del tema";
            b.text = "Bueno, de algo hay que morir, ponme toda la carta";
            c.text = "Ambas cosas me dan poca confianza";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo.";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";
            cor++;
        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿En serio? puedes elegir cualquier cosa. El café de Java es una maravilla, pero tienes la posibilidad de pedir cualquier otra cosa";
            a.text = "Que no, ahora me pones toda la carta";
            b.text = "Venga vale, por ser tu te dejo que me sirvas lo que quieras";
            c.text = "Tengo hambre";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya, se ve que la estrategia no ha funcionado muy bien...";
            a.text = "Pues no, la verdad";
            b.text = "No te preocupes, sigue intentándolo";
            c.text = "Quien la sigue la consigue";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se lo suelo decir a todo el mundo que lo pide, pero es mi café favorito. A mi padre le encantaba tomarlo en el trabajo con sus compañeros.";
            a.text = "Conque de ahí viene el nombre,...";
            b.text = "¿Ah si?";
            c.text = "No me interesa";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Un barraquito? Que es eso? Yo te recomendaría un café de Java, es más rápido";
            a.text = "Me fio de tus gustos, sírveme uno";
            b.text = "Me gusta mas el barraquito";
            c.text = "No me vendas la moto"; ;
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gajes del oficio";
            a.text = "Se te nota curtida en el asunto";
            b.text = "Te veo dolida";
            c.text = "Te entiendo, dame un abrazo";
            cor++;
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Espera espera, la carta es muy grande, no creo que puedas con todo";
            a.text = "¿Que no? Madre mía te digo yo a ti que si";
            b.text = "Subestimas mi poder";
            c.text = "Soy un pozo sin fondo";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vaya, se ve que la estrategia no ha funcionado muy bien...";
            a.text = "Pues no, la verdad";
            b.text = "No te preocupes, sigue intentándolo";
            c.text = "Quien la sigue la consigue";
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Hola";
            b.text = "Curioso el nombre";
            c.text = "Gracias ";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Ya sabes lo que quieres hoy?";
            a.text = "Aun no";
            b.text = "Estoy ocupado con una práctica, ponme un café";
            c.text = "Ponme lo de siempre";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Entonces te dejo más tiempo para decidir, avísame si quieres algo";
            a.text = "Bueno, ahora que lo pienso, ponme un vaso de agua";
            b.text = "¿Que me recomiendas para picar?";
            c.text = "(Quedarse callado)";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, ya sabes lo que dicen: “Si no lo logras a la primera, llámalo versión 1.0”. ¿Quieres azúcar?";
            a.text = "Espero no tener muchas versiones";
            b.text = "Ponme mucha azúcar, por favor";
            c.text = "Quiero que compile";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¡Un café de Java marchando!";
            a.text = "Ponme mucha azúcar, por favor";
            b.text = "(Teclear furiosamente)";
            c.text = "Menos mal que la cafetería está cerca";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Entrar a una cafetería a por un vaso de agua? Bueno, cosas peores se han visto";
            a.text = "Un codigo sin comentarios";
            b.text = "El live action de Death Note en Netflix";
            c.text = "Entregar una práctica un viernes a ultima hora";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues un editor de texto plano y mucha imaginación";
            a.text = "Vaaaale, mejor me voy";
            b.text = "Me refería de la carta";
            c.text = "Me ha gustado, no me lo esperaba";
            cor++;

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, eso significa que no quieres que te moleste";
            a.text = "Veo que pillas las indirectas";
            b.text = "Realmente no sé que pedir";
            c.text = "(Continuar callado)";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "El café seguro que te ayuda, enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Te veo estresado, tómate un descanso de vez en cuando";
            a.text = "Eso es lo que recomiendan todos";
            b.text = "Gracias por ser tan amable";
            c.text = "No hasta que no la termine";
            cor++;
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso es que se te escapó algún punto y coma, dale tiempo y revisa";
            a.text = "Veo que entiendes del tema";
            b.text = "Imposible";
            c.text = "Tendré que revisar mi código";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Te veo estresado, tómate un descanso de vez en cuando";
            a.text = "Eso es lo que recomiendan todos";
            b.text = "Gracias por ser tan amable";
            c.text = "No hasta que no la termine";
            cor++;
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tranquilo, no vaya a ser que pierdas el CTRL";
            a.text = "10/10 ";
            b.text = "Sin Ctrl +z pierdo la cabeza";
            c.text = "¿Has intentado ir al club de la comedia?";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es una gran ventaja para estudiantes. Además el precio está adaptado";
            a.text = "Todo bien mientras no suban el precio 0,2€";
            b.text = "Ya te digo, es una pasada";
            c.text = "No es para tanto";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Veo que no te cansas de venir por aquí. Me alegra que te guste la cafetería";
            a.text = "Es lo que tiene el café";
            b.text = "La cafetería tiene algo que a todos los informáticos nos atrae";
            c.text = "Exactamente, ponme un café para llevar";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Cuanta razón tienes. El café es casi indispensable para rendir al 100%... Aunque traigo una mala noticia. Se nos ha terminado el café de Java";
            a.text = "Menuda ironía";
            b.text = "Normal, es tan bueno que todo el mundo lo quiere probar";
            c.text = "Entonces me voy";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Creo que eso es más común de lo que nos pensamos";
            a.text = "Sírveme lo que quieras";
            b.text = "Somos como Homer y la cerveza";
            c.text = "Es nuestra kriptonita";
            cor++;

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Hace falta que pregunte el café que quieres?";
            a.text = "Creo que no";
            b.text = "Como quieras";
            c.text = "Tengo prisa";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ya, pero bueno, si quieres te puedo servir otra cosa";
            a.text = "Nah, mejor me voy";
            b.text = "Vale, lo dejo en tus manos";
            c.text = "Que no vuelva a pasar";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que agradable eres, veo que eres comprensible. No todo el mundo lo entiende.";
            a.text = "No te preocupes, es algo normal";
            b.text = "Esto no debería pasar nunca";
            c.text = "La gente siempre está enfadada por las mañanas";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Lo sentimos mucho, te podemos poner un cortado si quieres";
            a.text = "Mejor un barraquito";
            b.text = "No te preocupes por eso";
            c.text = "Que poca vergüenza";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " Me lo dejas en bandeja, ahora te traigo un cafe de Java";
            a.text = "¿Lo dices por ser camarera?";
            b.text = "Gracias, muy amable";
            c.text = "Cuanto antes mejor";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "O como Maggie y su chupete";
            a.text = "Vivan las referencias";
            b.text = "Ahi ya te pasaste";
            c.text = "No me sigas el juego";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que agradable es tener conversaciones así de vez en cuando";
            a.text = "Tu trabajo puede ser estresante";
            b.text = "Nunca viene mal";
            c.text = "Bueno, suficiente";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bastante obvio, ¿verdad?";
            a.text = "Nunca es demasiado obvio";
            b.text = "(Asentir con la cabeza)";
            c.text = "Pues si";
            cor++;
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¡Marchando un café de Java para llevar!";
            a.text = "Cuanta felicidad con tan poco";
            b.text = "No vuelvas a hacer eso por favor";
            c.text = "Espero que no nos hayan escuchado";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale vale, enseguida te lo traigo";
            a.text = "Lo que hay que soportar";
            b.text = "Quizás me pasé";
            c.text = "Que paciencia hay que tener";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buenos días. Bienvenido a la cafetería Oracle";
            a.text = "Bonito nombre";
            b.text = "...Mejor me siento";
            c.text = "Espero que por eso me pongas una buena taza de cafe";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " Llegados a este punto, ¿No te está taladrando la mente la musica?";
            a.text = "Pues un poco si";
            b.text = "La verdad es que ni me habia dado cuenta";
            c.text = "Me gustaría que tomases nota";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "La verdad es que los que la pusieron tienen bastante mal gusto. Pero no podemos hacer nada por ahora";
            a.text = "Yo cerraría el juego";
            b.text = "Me está entrando cáncer";
            c.text = "Dame mi café";
            cor++;
        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿En serio? Deberías ir al médico,... Por si acaso";
            a.text = "Yo sabré lo que me hago";
            b.text = "No creo, me está gustando";
            c.text = "Da igual, ponme un café";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Cierto, disculpa mis modales. ¿Que te sirvo?";
            a.text = "Ponme un cafe de Java";
            b.text = "Ponme un colacao";
            c.text = "Ponme un leche y leche";
            cor++;

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por favor, no hagas eso, te regalo un café Java";
            a.text = "Que facil ha sido eso";
            b.text = "Aun no es navidad";
            c.text = "¿Es mi cumpleaños?";
            cor++;

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ánimo, ya queda poco";
            a.text = "¡Muchas gracias!";
            b.text = "Quiero acabar este sufirmiento cuanto antes";
            c.text = "No quiero que acabe";
            cor++;
        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Dame un momentito y enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que antipático";
            a.text = "Lo siento, no me compila el código";
            b.text = "Dame un café, lo necesito";
            c.text = "Quizás me pasé ";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me sorprendes, eres el elegido";
            a.text = "Creo que ves demasiado cine";
            b.text = "¿El que traerá el equilibrio a la fuerza?";
            c.text = "¿Soy Neo?";
            cor++;
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Dame un momentito y enseguida te lo traigo";
            a.text = "Muchas gracias";
            b.text = "Date prisa";
            c.text = "Tengo ganas de probarlo";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Te pondré una taza grande porque me caes bien";
            a.text = "Que facil ha sido eso";
            b.text = "Aun no es navidad";
            c.text = "¿Es mi cumpleaños?";
            cor++;
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Solo tenemos Nesquik";
            a.text = "NO PUEDE SER";
            b.text = "Que desgraciado soy";
            c.text = "Eres de las mías #TeamNesquick";
            cor++;
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Qué mal gusto. Teniendo tanta variedad y pides eso";
            a.text = "Lo que hay";
            b.text = "Ya, soy una desgracia";
            c.text = "Pues a mi me gusta";
        }
    }

    public class Cpp
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ey novato.";
            a.text = "¿Es a mi?";
            b.text = "¿Yo?";
            c.text = "...";

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que te trae por los pasillos, Novato";
            a.text = "Estaba buscando a una persona que tiene mucha clase.";
            b.text = "Solo pasaba por aqui.";
            c.text = "No me llames Novato.";

        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Qué halagador, Que puedo hacer por ti?";
            a.text = "Quería pedirte ayuda con un problema de programación.";
            b.text = "¿Te gustaria ir a la cafetería algun dia?";
            c.text = "Solo queria conocerte.";
            cor++;
        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ah, que casualidad, tienes pinta de programar, ¿que lenguaje es el mas que te gusta?";
            a.text = "Python.";
            b.text = "Java.";
            c.text = "C++";

        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Lo siento, no sabia que no te gustara";
            a.text = "Pero si no me conoces de nada.";
            b.text = "No tenemos esa confianza.";
            c.text = "Es ofensivo.";

        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Prueba a buscar en internet, es lo que suelo hacer yo";
            a.text = "De acuerdo...";
            b.text = "Solo queria una segunda opinion, pero vale.";
            c.text = "Le preguntare a otro.";

        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "....¿Esto es una proposición?";
            a.text = "Es lo que tu quieras";
            b.text = "Puede";
            c.text = "Quien sabe";
            cor++;

        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bonita broma";
            a.text = "No es una broma..";
            b.text = "jajaja jaja ja si.. una broma";
            c.text = "(Alejarte en silencio)";
            cor++;

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No está mal pero no tiene tanta elegancia como C++, en la azotea esta la que más sabe de Python por si te interesa";
            a.text = "Despues ire a hacerle una visita.";
            b.text = "No creo que nadie sepas de Python que yo.";
            c.text = "No gracias, me valgo solo.";

        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pss menuda basura de lenguaje, en la cafeteria hay otra friki de ese lenguaje como tu.";
            a.text = "¿Estas celosa por que es mas facil de entender que tu?";
            b.text = "Tampoco hay que insultar.";
            c.text = "Tendre que ir a hacerle una visita";
            cor--;
        }

        public void actualizar_dia1123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "ENSERIO!! A mi tambien, es tan elegante con sus clases y sus punteros";
            a.text = "Es el mejor lenguaje del mundo";
            b.text = "Tampoco hay que pasarse, esta bien";
            c.text = "Un poco complicado pero es el mejor";
            cor++;
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tienes razón, soy C++ un placer conocerte";
            a.text = "Encantado.";
            b.text = "Por fin conozco a alguien que no me trata como un objeto.";
            c.text = "¿Como se dice C mas mas o C plus plus?.";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me lo suelen decir que me tomo muchas confianzas, lo siento";
            a.text = "No pasa nada, haremos como que no paso nada y ya.";
            b.text = "Tranquila.";
            c.text = "Lo importante es rectificar.";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Lo siento, no se volverá a repetir";
            a.text = "Es de sabios rectificar";
            b.text = "Eso espero";
            c.text = "Me alegro aclarar esto.";
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ayudame por favor";
            a.text = "(Quedarse callado)";
            b.text = "¿Que paso?";
            c.text = "Dime";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No encuentro a mi hermana pequeña C";
            a.text = "¿Le ha pasado algo?";
            b.text = "Tengo prisa.";
            c.text = "En que te puedo ayudar.";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Creo que si, esta mañana me encontré un ; y no es mio";
            a.text = "Tenemos que encontrarla cuanto antes";
            b.text = "¿Estas 100% segura que es de ella?";
            c.text = "Eso no me incunbe.";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Venga, seguro que tardaremos menos que lo que tardo en contar hasta 100 con un bucle";
            a.text = "¿Se supone que eso es poco?";
            b.text = "Bueno, dime que hago";
            c.text = "De verdad que no puedo, lo siento";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vamos a dividirnos para realizar una búsqueda binaria más eficiente.";
            a.text = "Yo me ire a buscarla en la cafetería";
            b.text = "Me gusta la idea, a donde voy a buscarla?";
            c.text = "Mejor una búsqueda secuencial";

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Muchas gracias, ¿por donde debemos buscar?";
            a.text = "Yo ire a la azotea";
            b.text = "Tu vete a las clases y yo a la cancha";
            c.text = "Vamos a la cafeteria, tal vez se esta tomando algo";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si, si. Ayudame por favor!";
            a.text = "¿Pero por que no lleva uno de repuesto?";
            b.text = "Vamos a la enfermeria, por si acaso";
            c.text = "Lo mejor sera separarnos";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " Eres peor que la gente que después de la función pone el { en otra línea.";
            a.text = "Eso es pasarse";
            b.text = "¿Peor que los capitan America? Eso son palabras mayores";
            c.text = "Es la mejor forma de programar";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es muy poco! Venga por favor!";
            a.text = "¿Cuanto de poco?";
            b.text = "Vale vale";
            c.text = "Yo tardo mucho en llegar a 100...";
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Mira que no ayudar a una damisela en apuros";
            a.text = "LLego tarde a clase";
            b.text = "Otro dia te ayudo";
            c.text = "(Salir corriendo)";
            cor--;
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Buena idea, yo ire a la cancha a ver si Ensamblador la ha visto";
            a.text = "Yo me ire a la cafeteria";
            b.text = "Voy contigo!";
            c.text = "¿Ensamblador?";
            cor++;
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Empieza por las clases que es donde suele estar";
            a.text = "Allé voy";
            b.text = "Espero encontrarla allí";
            c.text = "Usted manda";
            cor++;
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Es menos óptimo y no tenemos tiempo";
            a.text = "Lo que tu digas..";
            b.text = "Si, seguro";
            c.text = "Estas equivocada";
            cor--;
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hola alumno = New student";
            a.text = "Que graciosa eres";
            b.text = "No lo pillo";
            c.text = "En fin";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Parece que quieres decirme algo";
            a.text = "¿Que tal esta tu hermana despues de lo de ayer?";
            b.text = "Solo queria charlar";
            c.text = "(Mirar fijamente)";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Está mucho mejor, gracias por preguntar";
            a.text = "De nada hombre, para eso estamos";
            b.text = "Me alegro mucho";
            c.text = "Menos mal, estaba preocupado";
            cor++; cor++;

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y sobre que si se puede saber";
            a.text = "Sobre formas de programar";
            b.text = "Queria preguntarte sobre C";
            c.text = "¿Por que Ensamblador es tan rudo?";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me das miedo con esa mirada";
            a.text = "Lo siento, queria preguntarte qué lenguaje aparte de C++ me recomiendas";
            b.text = "(Mirar fijamente)";
            c.text = "Aveces siento que me ausento";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se ve que eres alguien confiable";
            a.text = "Tampoco me digas eso que me sonrojo";
            b.text = "Muchas gracias, tu tambien eres confiable una vez se te conoce bien";
            c.text = "Gracias...";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Todo se soluciono, en enfermería la arreglaron";
            a.text = "Menos mal";
            b.text = "Menos mal que tenemos a unos enfermeros expertos en programación";
            c.text = "¿No es raro que haya una enfermera en un instituto?";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hay muchas, pero yo soy una experta en Orientado a Objetos";
            a.text = "Le tendre que preguntar a otro";
            b.text = "¿Por eso tratas a todos como objetos?";
            c.text = "Como siempre, inútil";
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso mejor se lo preguntas a ella";
            a.text = "Pero es que no se como decirselo";
            b.text = "Que remedio";
            c.text = "¿Y no me puedes ayudar?";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se hace el rudo pero en el fondo es un cacho pan";
            a.text = "Sin él aun estariamos usando 1 y 0";
            b.text = "Tendre que conocerle mas";
            c.text = "No creo, es muy difícil de comprender";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Si me sabes dominar, no necesitaras nada mas";
            a.text = "Pero otros son mejores";
            b.text = "Creo que te hare caso";
            c.text = "Estas muy equivocado";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "De verdad que das miedo";
            a.text = "(Mirar fijamente)";
            b.text = "(Mirar fijamente)";
            c.text = "(Mirar fijamente)";
            cor = 0;
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c, ref int cor)
        {

            texto.text = "Eso pasa cuando te escogen para ser el prota de un juego";
            a.text = "¿De que hablas?";
            b.text = "Creo que tienes un error por ahi";
            c.text = "¿Seguro que hoy compiladas bien?";
        }


        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Solo hay 10 tipos de personas, las que saben binario y las que no";
            a.text = "(Quedarse en silencio)";
            b.text = "(Reirse un poco)";
            c.text = "(Risa falsa)";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿No te gusto el chiste?";
            a.text = "No mucho la verdad. ¿No tienes otro?";
            b.text = "Mejor que te retires de contar chistes.";
            c.text = "Prueba de nuevo";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No, solo se me ha ocurrido ese";
            a.text = "Podemos pensar otro juntos";
            b.text = "Mejor me voy marchando";
            c.text = "Pues será mejor que te retires";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿No me puedes dar una critica mas constructiva?";
            a.text = "Te lo podría decir de otra manera pero seguramente esto dejaría de ser PEGI7.";
            b.text = "Podrías probar otro tipo de humor.";
            c.text = "No.";
            cor--;

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "El campeón del escondite es ; desde el 58";
            a.text = "Algo mejor pero mejorable";
            b.text = "Bueno..";
            c.text = "Por favor para, que estas perdiendo clase";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Vale! ¿Que se te ocurre?";
            a.text = "¿Que tal algo menos friki?";
            b.text = "Algo que mas gente pueda entender";
            c.text = "Prueba con un monologo";
            cor++;
        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Siento haberte hecho perder el tiempo";
            a.text = "No pasa nada";
            b.text = "Tampoco me has hecho perder el tiempo, hombre";
            c.text = "No te pongas asi, sigue intentandolo";

        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tampoco hay que ser grosero";
            a.text = "No volvera a pasar";
            b.text = "Seré como quiera";
            c.text = "Aye sir!";

        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No entiendo";
            a.text = "Cosas de mayores";
            b.text = "Cosas nuestras";
            c.text = "(Sonreir de manera rara)";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por ejemplo, ¿crees que podría hacer monólogos?";
            a.text = "Todo es proponerselo";
            b.text = "Prueba otra cosa";
            c.text = "Bueno";
            cor++;
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gracias, me seguiré esforzando";
            a.text = "De nada, sigue asi";
            b.text = "Asi es como se hace";
            c.text = "Lucha por tus sueños";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "A que te refieres con Bueno?";
            a.text = "Mejorable";
            b.text = "A la misma altura que el otro";
            c.text = "Psss";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¡¿Si sigo asi me convertire en C?!";
            a.text = "Es una posibilidad";
            b.text = "Nunca se sabe";
            c.text = "No hombre no, a tal punto no";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Hombre cuanto tiempo!";
            a.text = "...";
            b.text = "¿Que es lo que quieres?";
            c.text = "¿Que pasa?";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Me podrias ayudar con una practica?";
            a.text = "Justo ahora no puedo, lo siento";
            b.text = "¿En que lenguaje?";
            c.text = "Que remedio, cuentame";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿De verdad que no me puedes ayudar ni un poco?";
            a.text = "Nada de nada, lo siento";
            b.text = "Bueno pero solo puedo 5 minutos";
            c.text = "(Irte sin mirar atras)";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues en Python";
            a.text = "¿Y por que no le preguntas a la profesional?";
            b.text = "No lo domino, lo siento";
            c.text = "Veamos que se puede hacer";
            cor++;

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Debo terminar esta practica en python y no entiendo como hacer esta función";
            a.text = "Mejor preguntale a ella";
            b.text = "Buff, al final mejor creo que no te puedo ayudar";
            c.text = "Veré";

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gracias por tu tiempo";
            a.text = "De verdad que lo siento";
            b.text = "Otro dia si eso";
            c.text = "Si estas libre en un rato te ayudo";

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Muchas gracias! Mira esta función!";
            a.text = "Uff, creo que necesitas a alguien experto";
            b.text = "(Creo que se nota mucho que no se que decirle)";
            c.text = "(Fingir dolor de cabeza e irte)";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "De verdad que eres un impresentable";
            a.text = "...";
            b.text = "...";
            c.text = "...";
            cor--;

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me niego a preguntarle a ella, se cree supeior a mi!";
            a.text = "Lo es..";
            b.text = "igual que tu te crees superior a C";
            c.text = "Hay que dejar la dignidad de lado aveces";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gracias por intentarlo";
            a.text = "De nada";
            b.text = "De verdad que lo siento";
            c.text = "(Encogerse de hombros)";
            cor++;



        }



        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Mira";
            a.text = "chiste(Ayuda miguel)";
            b.text = "5.1332";
            c.text = "5.1333";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Como tu por aqui?";
            a.text = "Estudio aqui";
            b.text = "¿Pasa algo?";
            c.text = "¿No puedo estar aqui?";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me sorprende que estes en el Insti un sabado";
            a.text = "Te podria decir lo mismo";
            b.text = "Venia al club";
            c.text = "Simplemente no tenia nada que hacer";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Yo vine por el club de programacion Orientada a objetos";
            a.text = "¿Eres la jefa del club no?";
            b.text = "Menudo rollo de club";
            c.text = "Yo pertenezco al de programación de riesgo";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que club?";
            a.text = "El de programadción de riesgo";
            b.text = "No te quiero aburrir";
            c.text = "Uno parecido al tuyo pero de programacion de riesgo";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Te quieres unir a mi club?";
            a.text = "No me gustan mucho los clubs";
            b.text = "Muchas responsabilidades";
            c.text = "Prefiero estar en mi casa";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "En efecto! ¿Como lo has sabido?";
            a.text = "Por que eres la mas indicada";
            b.text = "Intuición";
            c.text = "Por que me informe bien de los clubes que habia";
            cor++;

        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Como te atreves a decir eso!";
            a.text = "Yo soy mas de programacion procedural";
            b.text = "Me gusta mas tu hermana, C es mejor";
            c.text = "Python sin sus punteros es lo mejor, sin dudarlo";

        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿De alto riesgo? ¿Es una broma?";
            a.text = "Si";
            b.text = "No, se trata de dejar todo para el ultimo momento";
            c.text = "Por supuesto!, ¿como va a existir algo asi?";

        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Venga, cuentame anda";
            a.text = "Nah";
            b.text = "Es demasiado aburrido";
            c.text = "Lo siento, debo irme";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Parecido al mio? Y cual es la diferencia";
            a.text = "NULL";
            b.text = "Que es mas divertido";
            c.text = "Que lo hacemos todo con mas prisa";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "!Pero los dos juntos hariamos buen equipo!";
            a.text = "Se me da mejor trabajar solo";
            b.text = "No trabajo con gente como tu";
            c.text = "¡Me parece una fantastica idea!";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Aburrido";
            a.text = "Me gusta mas llamarme clasico";
            b.text = "Puede ser";
            c.text = "Me gusta demasiado no hacer nada, lo siento";
            cor--;
        }
    }

    public class Php
    {
        int love;
        int veces_visitado;
        //DAY 1
        public void actualizar_dia1(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Oh,... H-Hola. No esperaba encontrarme a nadie aquí";
            a.text = "Soy nuevo";
            b.text = "Hola";
            c.text = "No es el mejor lugar para esconderse";
            

        }
        public void actualizar_dia11(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Qué haces en la cocina? Se supone que no deberías estar aquí";
            a.text = "Solo tenía curiosidad";
            b.text = "Me llama la atención este lugar";
            c.text = "Tengo dudas sobre programación";
            
        }

        public void actualizar_dia111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Oh, bueno, me presento, soy Php. Siempre suelo estar escondida porque me da vergüenza relacionarme con la gente. Me suelen confundir a veces con mis primas Html y Css3, pero somos muy diferentes";
            a.text = "Entiendo, pero…¿Por qué eres tan tímida?";
            b.text = "Increíble";
            c.text = "El que te confunda está ciego";
            
        }

        public void actualizar_dia112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No es nada del otro mundo, la verdad";
            a.text = "Me gusta comer cuando no me sale un codigo";
            b.text = "A mi se me hace acogedor";
            c.text = "Aquí pueden surgir buenas ideas";
            
        }

        public void actualizar_dia113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, yo no sé si te puedo ayudar...";
            a.text = "Venga, échame una mano";
            b.text = "Bueno, tendré que pedirle ayuda a Python";
            c.text = "No te preocupes, ya me buscaré la vida";
            
        }

        public void actualizar_dia1111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No sé, simplemente estoy aquí detrás haciendo mis cosas y en mi mundo";
            a.text = "Somos iguales";
            b.text = "Debería darte el sol un poco";
            c.text = "Te dejo sola entonces";
           
        }

        public void actualizar_dia1112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Tu crees? A veces pienso que hago las cosas muy mal";
            a.text = "No digas eso";
            b.text = "No te preocupes por eso";
            c.text = "Yo no lo veo asi";
            cor++;
        }

        public void actualizar_dia1113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, no se yo.";
            a.text = "Sois muy diferentes";
            b.text = "El color os diferencia";
            c.text = "Es verdad, sois iguales";

        }

        public void actualizar_dia1121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso ayuda a algunas personas, me incluyo entre ellas";
            a.text = "Tampoco hay que abusar";
            b.text = "Somos iguales";
            c.text = "A Goku le funciona";
            cor++;
        }

        public void actualizar_dia1122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Cuando llevas un tiempo aquí se le coge cariño";
            a.text = "Tienes toda la razón";
            b.text = "¿Es como tu batcueva?";
            c.text = "No te creo";
        }
		public void actualizar_dia1123(Text texto, Text a, Text b, Text c, ref int cor)
		{
			texto.text = "Gracias a este lugar pude crear mi primer servidor web";
            a.text = "¡Que guay!";
            b.text = "Eres sorprendente";
            c.text = "Ojalá pudiese hacer lo mismo";
            cor++;
        }

        public void actualizar_dia1131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Mmmm,... En otro momento quizás";
            a.text = "Vale";
            b.text = "No te insisto mas";
            c.text = "Eso es relativo";
        }

        public void actualizar_dia1132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ni hablar, por ahí si que no paso. ¿Cuáles son tus dudas?";
            a.text = "Que facil ha sido eso";
            b.text = "Nadie diría que te picas con facilidad";
            c.text = "Sospechoso,...";
        }

        public void actualizar_dia1133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eres muy comprensible, gracias.";
            a.text = "Nada, para eso estamos";
            b.text = "De nada";
            c.text = "(Irse)";
        }

        //DIA 2

        public void actualizar_dia2(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " Oh,... Eres tu, no me des esos sustos";
            a.text = "¿Tan difícil de ver soy?";
            b.text = "Soy un ninja";
            c.text = "Lo siento";

        }
        public void actualizar_dia21(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Creía haberte dicho que soy muy vergonzosa, de ahí que siempre esté detrás...";
            a.text = "Ya, pero tenía que preguntarte algo";
            b.text = "Siempre me dices lo mismo";
            c.text = "Lo siento";

        }

        public void actualizar_dia211(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y de qué se trata?";
            a.text = "Quiero una expresión regular para letras mayúsculas";
            b.text = "Quiero una expresion regular para alternar entre coincidencias";
            c.text = "Quiero validar un código postal";

        }

        public void actualizar_dia212(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pero es la verdad. Estoy trabajando en algo muy importante, no me molestes";
            a.text = "Podría ayudarte";
            b.text = "Bueno, entonces me voy";
            c.text = "Entiendo...";

        }

        public void actualizar_dia213(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No, es culpa mía, perdón. Estoy estresada con este código que no me sale";
            a.text = "Podría ayudarte";
            b.text = "Creo que mejor te dejo tiempo para pensar";
            c.text = "Podrías pedirle ayuda a Manz";
            cor++;

        }

        public void actualizar_dia2111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso es facilísimo mira: [^A-Z] ";
            a.text = "Es verdad";
            b.text = "Soy tontísimo";
            c.text = "Sabes mucho";

        }

        public void actualizar_dia2112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eso es de infantil, utiliza la barra |, por ejemplo: este|esto|esta ";
            a.text = "Es verdad";
            b.text = "Soy tontísimo";
            c.text = "Sabes mucho";

        }

        public void actualizar_dia2113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Por favor, parece mentira que no lo sepas: ^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$ ";
            a.text = "Es verdad";
            b.text = "Soy tontísimo";
            c.text = "Sabes mucho";

        }

        public void actualizar_dia2121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " ¿Sabrías decirme como validar una URL?";
            a.text = "Ni idea";
            b.text = "Pregúntale a los profesores";
            c.text = "Si te digo te miento";
        }

        public void actualizar_dia2122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gracias por entenderlo";
            a.text = "No hay de que";
            b.text = "Tampoco quiero entrometerme";
            c.text = "Suerte con eso";
            cor++;
        }

        public void actualizar_dia2123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Aunque si me ayudas te dejo quedarte";
            a.text = "Haré un esfuerzo";
            b.text = "Venga, vamos a ver ese código";
            c.text = "Manos a la obra";
            cor++;
        }

        public void actualizar_dia2131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Sabrías decirme como validar una URL?";
            a.text = "Ni idea";
            b.text = "Pregúntale a los profesores";
            c.text = "Si te digo te miento";
        }

        public void actualizar_dia2132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Gracias por entenderlo";
            a.text = "No hay de que";
            b.text = "Tampoco quiero entrometerme";
            c.text = "Suerte con eso";
            cor++;
        }

        public void actualizar_dia2133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Manz? ¿Quien es ese?";
            a.text = "Es un profesor";
            b.text = "Explica de maravilla";
            c.text = "Tiene un par de cursos muy interesantes";
        }

        //DIA3

        public void actualizar_dia3(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ey, rápido ven, necesito tu ayuda";
            a.text = "Miedo me da";
            b.text = "¿Que ocurre?";
            c.text = "¿Que pasó ahora?";

        }
        public void actualizar_dia31(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Dime si ves algún fallo en el código...";
            a.text = "Mira, no soy un experto";
            b.text = "Te falta un break";
            c.text = "Estás haciendo mal las comparaciones";

        }

        public void actualizar_dia311(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Jo, esperaba que pudieses ayudarme...";
            a.text = "Bueno venga, solo por esta vez";
            b.text = "Al menos podrías decir: “Por favor” ";
            c.text = " Mejor me voy";

        }

        public void actualizar_dia312(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " ¿Cómo lo has visto tan rápido?";
            a.text = "Amiga mía, experiencia";
            b.text = "Es un error bastante común";
            c.text = "Me pasó ayer";

        }

        public void actualizar_dia313(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Cómo que las estoy haciendo mal? Están bien, mira, revísalo de nuevo";
            a.text = "Comparas con ==, no con =";
            b.text = "No puedes poner !==, solo !=";
            c.text = "Te falta el $ en la variable";

        }

        public void actualizar_dia3111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿En serio? Menos mal, estaba a punto de tirarme de los pelos";
            a.text = "Siempre ayuda tener a alguien";
            b.text = "Un pequeño empujoncito nunca viene mal";
            c.text = "Yo te ayudo";
            cor++;
        }

        public void actualizar_dia3112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " L-lo siento, he sido muy descuidada";
            a.text = "No, es culpa mía";
            b.text = "Procura que no se repita";
            c.text = "No pasa nada";

        }

        public void actualizar_dia3113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ya me buscaré la vida para sacar esto, te veo luego.";
            a.text = "Tengo prisa";
            b.text = "He de regresar al futuro";
            c.text = "Se me hizo tarde";

        }

        public void actualizar_dia3121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Que crack estás hecho";
            a.text = "¿Sabes con quién estás hablando?";
            b.text = "Por favor, no es para tanto";
            c.text = "La práctica hace al maestro";
            cor++;
        }

        public void actualizar_dia3122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se ve que entiendes un montón";
            a.text = "¿Sabes con quién estás hablando?";
            b.text = "Por favor, no es para tanto";
            c.text = "La práctica hace al maestro";
        }

        public void actualizar_dia3123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y yo revisando el código por semejante bobería";
            a.text = "Suele pasar con mucha frecuencia";
            b.text = "Hay que tener más cuidado";
            c.text = "Despreocúpate";
        }

        public void actualizar_dia3131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No puede ser,... Estoy fatal";
            a.text = "Suele pasar con mucha frecuencia";
            b.text = "Hay que tener más cuidado";
            c.text = "Despreocúpate";
        }

        public void actualizar_dia3132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Y yo revisando el código por semejante bobería";
            a.text = "Suele pasar con mucha frecuencia";
            b.text = "Hay que tener más cuidado";
            c.text = "Despreocúpate";
        }

        public void actualizar_dia3133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Soy tontísima ¡Muchísimas gracias!";
            a.text = "Gracias a ti";
            b.text = "No hay de que";
            c.text = "3€";
            cor++;
        }

        //DIA 4

        public void actualizar_dia4(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Oye ¿podrías ayudarme con este código?";
            a.text = "¡Claro!";
            b.text = "¿Tengo opción?";
            c.text = "Que se le va a hacer,...";

        }
        public void actualizar_dia41(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Me da muchísimos errores, pero no sé el motivo";
            a.text = "Si utilizas Ñ y tildes debes poner UTF-8";
            b.text = "Prueba a buscar en Stack Overflow";
            c.text = "Creo que mejor me voy";

        }

        public void actualizar_dia411(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Soy experta en fallos tontos, de verdad que estoy fatal";
            a.text = "Tranquila, es bastante común errores así";
            b.text = "Pues sí, deberías prestar más atención";
            c.text = " No pasa nada, yo estoy aquí para ayudarte";

        }

        public void actualizar_dia412(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Pues no lo había pensado, la verdad";
            a.text = "Deberías usarlo con más frecuencia, es una maravilla";
            b.text = "No te voy a decir las veces que me ha salvado";
            c.text = "Úsalo con moderación";

        }

        public void actualizar_dia413(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Nooo, por favor ¡Necesito ayuda urgente!";
            a.text = "¡Mira! ¡Un gato volador!";
            b.text = "No creo poder ayudarte";
            c.text = "Lo veo más negro que mi futuro";

        }

        public void actualizar_dia4111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Se ve que entiendes un montón";
            a.text = "¿Sabes con quién estás hablando?";
            b.text = "Por favor, no es para tanto";
            c.text = "La práctica hace al maestro";

        }

        public void actualizar_dia4112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " L-lo siento, no volverá a ocurrir";
            a.text = "No es para ponerse asi";
            b.text = "Bueno bueno, ya verás que lo haces mejor para la próxima";
            c.text = "Anímate";
            cor++;
        }

        public void actualizar_dia4113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eres la persona más maravillosa de este instituto";
            a.text = "No lo creo";
            b.text = "¿Tu crees?";
            c.text = "Me vas a sonrojar";
            cor++;
        }

        public void actualizar_dia4121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "A partir de ahora lo usaré mucho, hay un montón de cosas útiles";
            a.text = "Tampoco abuses";
            b.text = "Un gran poder conlleva una gran responsabilidad";
            c.text = "No sucumbas al lado oscuro";
        }

        public void actualizar_dia4122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No lo digas muy alto, podrían haber profesores rondando";
            a.text = "Tengo el mapa de los merodeadores";
            b.text = "No te preocupes";
            c.text = "Tengo la antena puesta, no pasará nada";
            cor++;
        }

        public void actualizar_dia4123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Por qué lo dices?";
            a.text = "Un gran poder conlleva una gran responsabilidad";
            b.text = "Sauron acabó peor por lo mismo";
            c.text = "No es bueno abusar";
        }

        public void actualizar_dia4131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Dónde? ¿Dónde?";
            a.text = "No puedo creer que caigas en eso";
            b.text = "Te lo perdiste";
            c.text = "(Salir corriendo)";
        }

        public void actualizar_dia4132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = " Creía que se te daba bien esto";
            a.text = "No mucho";
            b.text = "No te creas";
            c.text = "Que chiste mas bueno";
        }

        public void actualizar_dia4133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Venga, no seas pesimista";
            a.text = "Soy realista";
            b.text = "Es lo que se suele decir ¿No?";
            c.text = "No lo soy";
        }

        //DIA 5

        public void actualizar_dia5(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Ey! ¿Qué tal? Antes me contaron el mejor chiste del mundo ¿Quieres escucharlo?";
            a.text = "Venga";
            b.text = "No por favor";
            c.text = "Sé que me lo vas a contar aunque no quiera";

        }
        public void actualizar_dia51(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Sabes cuál es el virus mas extendido del mundo? El sistema windows";
            a.text = "Cuanta razón";
            b.text = "Cuanto odio hacia Windows";
            c.text = "Cierto, Linux es una maravilla";

        }

        public void actualizar_dia511(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Verdad? Mira, pues te voy a contar otro: ¿Sabes lo que le dice un .GIF a un .JPG? Anímate hombre";
            a.text = "Esto está yendo demasiado lejos";
            b.text = "Para, por favor";
            c.text = "Me voy";

        }

        public void actualizar_dia512(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Nunca es suficiente";
            a.text = "Yo creo que si";
            b.text = "Es verdad, nunca es suficiente";
            c.text = "No te metas con el mejor sistema del mundo";

        }

        public void actualizar_dia513(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No por favor, es el azúcar, que se me sube a la cabeza y hoy no he ido a visitar a Java. Me falta café";
            a.text = "Yo iba a ir ahora";
            b.text = "Fui hace nada, muy maja";
            c.text = "Aun no he ido";
            cor++;

        }

        public void actualizar_dia5111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Aún tengo más ¿Quieres escucharlos?";
            a.text = "Si por favor";
            b.text = "No por favor";
            c.text = "(Suspirar)";
            cor++;

        }

        public void actualizar_dia5112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Son buenísimos";
            a.text = "Lo que hay que soportar";
            b.text = "¿Hay vacantes para el club de la comedia?";
            c.text = "Eres la mejor";

        }

        public void actualizar_dia5113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Venga, ANIMATE hombre";
            a.text = "Callate";
            b.text = "Ay dios mio";
            c.text = "No por favor";

        }

        public void actualizar_dia5121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno bueno, quizás me pasé un poco";
            a.text = "Estoy de broma";
            b.text = "Te pasaste de la raya";
            c.text = "Por menos Rusia invadió Polonia";
        }

        public void actualizar_dia5122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Quizás nos estamos precipitando un poco";
            a.text = "Yo creo que no";
            b.text = "En verdad si";
            c.text = "Tienen que ponerse las pilas";
        }

        public void actualizar_dia5123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno bueno, quizás me pasé un poco";
            a.text = "Yo creo que no";
            b.text = "En verdad si";
            c.text = "Estoy ofendido";
        }

        public void actualizar_dia5131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Dale saludos de mi parte";
            a.text = "Lo haré";
            b.text = "Claro, sin problema";
            c.text = "A ver si me acuerdo";
            cor++;
        }

        public void actualizar_dia5132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Ya te explicó el origen del café?";
            a.text = "Siempre lo hace";
            b.text = "En verdad no";
            c.text = "Ya me lo sabía";
        }

        public void actualizar_dia5133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No lo dejes pasar, queda poco tiempo";
            a.text = "Gracias por avisarme";
            b.text = "Vale, voy corriendo";
            c.text = "No me apetece";
        }

        //DIA 6

        public void actualizar_dia6(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Tu por aquí? Ya terminaron las clases";
            a.text = "Que va, me salté un par ";
            b.text = "Por supuesto";
            c.text = "Aun no han empezado";

        }
        public void actualizar_dia61(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Que haces entrando a la cocina? ¡Y con el portátil en las manos! Como se te caiga no me hago responsable";
            a.text = "Acabo de salir de una práctica";
            b.text = "No pasa nada, esto es más duro que un Nokia 3210";
            c.text = "A un amigo se le cayó el Mac el otro día";

        }

        public void actualizar_dia611(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Y qué tal te salió?";
            a.text = "Horrible, para septiembre que me voy";
            b.text = "Genial, era una chorrada";
            c.text = "Meh, a ver si hay suerte";

        }

        public void actualizar_dia612(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Yo no me la jugaría, guardalo. Te puedes resbalar y la liamos";
            a.text = "Bueno vale, te haré caso";
            b.text = "No lo voy a guardar";
            c.text = "Lo dejo en la mesa, que de ahí no se va a mover";

        }

        public void actualizar_dia613(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿Qué me estas comentando?";
            a.text = "Lo que escuchas";
            b.text = "Y aún sigue vivo";
            c.text = "Es un caso perdido";

        }

        public void actualizar_dia6111(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No creo, ya verás que al final te aprueban";
            a.text = "Que positiva eres";
            b.text = "Creo que las cosas no van así";
            c.text = "Dios te oiga";
            cor++;
        }

        public void actualizar_dia6112(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "No esperaba menos de ti";
            a.text = "He nacido para esto";
            b.text = "Todo es gracias a tus enseñanzas";
            c.text = "Tampoco te vengas arriba";
            cor++;
        }

        public void actualizar_dia6113(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bueno, las otras las tendrás aprobadas ¿Verdad?";
            a.text = "Cuanta fe";
            b.text = "(Sonreir)";
            c.text = "Me da que no";

        }

        public void actualizar_dia6121(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Bien, mejor prevenir que curar";
            a.text = "No es barato el portátil";
            b.text = "Este portátil es una chatarra";
            c.text = "Tampoco lo estoy usando mucho";
        }

        public void actualizar_dia6122(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Tu verás lo que haces";
            a.text = "No pasa nada";
            b.text = "Está a salvo conmigo, como el anillo del poder";
            c.text = "Es mi tesoooro";
        }

        public void actualizar_dia6123(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Eres de lo que no hay";
            a.text = "Me lo dicen con frecuencia";
            b.text = "Al menos estará a salvo";
            c.text = "No tendrás gatos por aquí ¿No?";
        }

        public void actualizar_dia6131(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "Yo ya estaría muerta si me pasara eso";
            a.text = "Él ya no está entre nosotros ";
            b.text = "Tu y todos";
            c.text = "Es solo un portátil";
        }

        public void actualizar_dia6132(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿El portátil o él?";
            a.text = "El portátil";
            b.text = "Él";
            c.text = "Ambas";
            cor++;
        }

        public void actualizar_dia6133(Text texto, Text a, Text b, Text c, ref int cor)
        {
            texto.text = "¿El portátil o él?";
            a.text = "El portátil";
            b.text = "Él";
            c.text = "Ambas";
            cor++;
        }
    }



    public GameObject Fondo;
    Image myimagecomponent;
    public Sprite habitacion;
    public Sprite clase;
    public Sprite intro;
    //Ensamblador
    public Sprite gimnasio;
    public Sprite ensamblador;
    //Python
    public Sprite python;
    public Sprite entrada;
    //Java
    public Sprite java;
    public Sprite cafeteria;
    //Php
    public Sprite php;
    public Sprite cocin;
    //C
    public Sprite ce;
    public Sprite clasee;
    //Cpp
    public Sprite cepp;
    public Sprite pasilo;
	public Sprite InLove;
	public Text Final;
	public GameObject Final_;
	public GameObject botonfinal;
    public GameObject habitacion1;
    public GameObject habitacion2;
    public GameObject habitacion3;
    public GameObject habitacion4;
    public GameObject habitacion5;
    public GameObject habitacion6;
    public GameObject mainbutton;
    public GameObject opcion1;
    public Text op1;
    public GameObject opcion2;
    public Text op2;
    public GameObject opcion3;
    public Text op3;
    public GameObject textbox;
    public Text textb;
    public GameObject Daybox;
    public GameObject Corazones;
    public Text corazon1;
    public Text corazon2;
    public Text corazon3;
    public Text corazon4;
    public Text corazon5;
    public Text corazon6;
    public int cor1 = 0; public int cor2 = 0; public int cor3 = 0; public int cor4 = 0; public int cor5 = 0; public int cor6 = 0;
    public GameObject chica;
    public Text contadordiastext;
    public int seleccion = 4;//variable para marcar la seleccion hecha
    GameObject[] habitaciones;
    GameObject[] opciones;
    int loli = 0; //Que loli es escogida para este dia
    int momento = 1; //En qe momento del dia nos encontramos, hay 5 momentos por dia
    int Booton = 0; //Que boton se ha pulsado
    int OldBooton = 0;
    int daycounter = 0; //CONTADOR DEL DIA QUE ES

    C waifu1 = new C();
    Php waifu2 = new Php();
    Cpp waifu3 = new Cpp();
    Java waifu4 = new Java();
    Python waifu5 = new Python();
    Ensamblador waifu6 = new Ensamblador();
	private void actualizarcorazones() {//para marcar la opcion correcta que te aumenta hacer cor1++; para la instawin cor1 + 6
        corazon1.text = cor1.ToString();
        corazon2.text = cor2.ToString();
        corazon3.text = cor3.ToString();
        corazon4.text = cor4.ToString();
        corazon5.text = cor5.ToString();
        corazon6.text = cor6.ToString();
    }
    private void mostrarbotonesmenu() {
        foreach (GameObject a in habitaciones)
        {
            a.active = true;
        }
        actualizarcorazones();
        Corazones.active = true;

    }
    private void ocultarbotonesmenu()
    {
        foreach (GameObject a in habitaciones)
        {
            a.active = false;
        }
        Corazones.active = false;
    }
    private void ocultaropciones()
    {
        foreach (GameObject a in opciones)
        {
            a.active = false;
        }
    }
    private void mostraropciones()
    {
        foreach (GameObject a in opciones)
        {
            a.active = true;
        }
    }


    private void Start()    {
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = intro;
        GameObject[] dummy = { habitacion1, habitacion2, habitacion3, habitacion4, habitacion5, habitacion6 };
        GameObject[] dummy2 = { opcion1, opcion2, opcion3};
        habitaciones = dummy;
        opciones = dummy2;
        ocultarbotonesmenu();
        ocultaropciones();
		Final_.active = false;
		botonfinal.active = false;
        textbox.active = false;
        Daybox.active = false;
        chica.active = false;
    }
    void Update () {}
	public void buttonfinal(){
		SceneManager.LoadScene ("Créditos");
	}

    public void inicio () {
        daycounter++;
		if (daycounter > 6) {
			chica.active = false;
			ocultaropciones ();
			textbox.active = false;
			myimagecomponent.sprite = InLove;
			botonfinal.active = true;
			string dummy = "";
			if (cor1 > 4) {
				dummy += " C, ";
			}
			if (cor2 > 4) {
				dummy += " PHP, ";
			}
			if (cor3 > 4) {
				dummy += " C++, ";
			}
			if (cor4 > 4) {
				dummy += " Java, ";
			}
			if (cor5 > 4) {
				dummy += " Python, ";
			}
			if (cor6 > 4) {
				dummy += " Ensamblador ";
			}
			if (dummy == "") {
				dummy = "Nadie ";
			}
			Final.text = dummy + " se han enamorado de ti.";
			Final_.active = true;

		} else {
			contadordiastext.text = daycounter.ToString ();
			myimagecomponent.sprite = habitacion;
			mainbutton.active = false;
			mostrarbotonesmenu ();
			ocultaropciones ();
			textbox.active = false;
			Daybox.active = true;
			chica.active = false;
		}
    }

    public void Boton1()
    {
        OldBooton = Booton;
        Booton = 1;
        switch (loli)
        {
            case 1:
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
                break;
            case 6:
                cancha();
                break;
        }
        momento++;
    }
    public void Boton2()
    {
        OldBooton = Booton;
        Booton = 2;
        switch (loli)
        {
            case 1:
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
                break;
            case 6:
                cancha();
                break;
        }
        momento++;
    }

    public void Boton3()
    {
        OldBooton = Booton;
        Booton = 3;

        switch (loli)
        {
            case 1:
                cpp();
                break;
            case 2:
                cocina();
                break;
            case 3:
                pasillos();
                break;
            case 4:
                cafe();
                break;
            case 5:
                azotea();
                break;
            case 6:
                cancha();
                break;
        }
        momento++;
    }

    public void cpp()
    {

        loli = 1;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = clasee;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = ce;
        image.rectTransform.sizeDelta = new Vector2(490,685);


        switch (daycounter) {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia1(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia11(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia111(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia112(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia113(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia1131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia1132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia1133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia2(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia21(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia211(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia212(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia213(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia2131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia2132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia2133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia3(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia31(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia311(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia312(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia313(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia3131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia3132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia3133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia4(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia41(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia411(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia412(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia413(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia4131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia4132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia4133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia5(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia51(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia511(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia512(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia513(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia5131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia5132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia5133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu1.actualizar_dia6(textb, op1, op2, op3, ref cor1);
                        break;
                    case 2:
                        waifu1.actualizar_dia61(textb, op1, op2, op3, ref cor1);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu1.actualizar_dia611(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 2)
                            waifu1.actualizar_dia612(textb, op1, op2, op3, ref cor1);
                        else if (Booton == 3)
                            waifu1.actualizar_dia613(textb, op1, op2, op3, ref cor1);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6111(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6112(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6113(textb, op1, op2, op3, ref cor1);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6121(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6122(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6123(textb, op1, op2, op3, ref cor1);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu1.actualizar_dia6131(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 2)
                                    waifu1.actualizar_dia6132(textb, op1, op2, op3, ref cor1);
                                else if (Booton == 3)
                                    waifu1.actualizar_dia6133(textb, op1, op2, op3, ref cor1);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void cocina()
    {
        loli = 2;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = cocin;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = php;
        image.rectTransform.sizeDelta = new Vector2(300, 600);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia1(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia11(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia111(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia112(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia113(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia1131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia1132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia1133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia2(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia21(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia211(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia212(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia213(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia2131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia2132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia2133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia3(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia31(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia311(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia312(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia313(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia3131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia3132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia3133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia4(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia41(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia411(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia412(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia413(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia4131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia4132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia4133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia5(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia51(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia511(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia512(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia513(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia5131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia5132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia5133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu2.actualizar_dia6(textb, op1, op2, op3, ref cor2);
                        break;
                    case 2:
                        waifu2.actualizar_dia61(textb, op1, op2, op3, ref cor2);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu2.actualizar_dia611(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 2)
                            waifu2.actualizar_dia612(textb, op1, op2, op3, ref cor2);
                        else if (Booton == 3)
                            waifu2.actualizar_dia613(textb, op1, op2, op3, ref cor2);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6111(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6112(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6113(textb, op1, op2, op3, ref cor2);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6121(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6122(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6123(textb, op1, op2, op3, ref cor2);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu2.actualizar_dia6131(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 2)
                                    waifu2.actualizar_dia6132(textb, op1, op2, op3, ref cor2);
                                else if (Booton == 3)
                                    waifu2.actualizar_dia6133(textb, op1, op2, op3, ref cor2);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void pasillos()
    {
        loli = 3;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = pasilo;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = cepp;
        image.rectTransform.sizeDelta = new Vector2(300, 685);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia1(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia11(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia111(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia112(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia113(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1112(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1123(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia1131(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia1132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia1133(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia2(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia21(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia211(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia212(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia213(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2112(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2123(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia2131(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia2132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia2133(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia3(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia31(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia311(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia312(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia313(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3123(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia3131(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia3132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia3113(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia4(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia41(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia411(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia412(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia413(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4112(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4122(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia4131(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia4132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia4133(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia5(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia51(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia511(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia512(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia513(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5112(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5112(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia5121(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia5122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia5133(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu3.actualizar_dia6(textb, op1, op2, op3, ref cor3);
                        break;
                    case 2:
                        waifu3.actualizar_dia61(textb, op1, op2, op3, ref cor3);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu3.actualizar_dia611(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 2)
                            waifu3.actualizar_dia612(textb, op1, op2, op3, ref cor3);
                        else if (Booton == 3)
                            waifu3.actualizar_dia613(textb, op1, op2, op3, ref cor3);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6111(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6112(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6113(textb, op1, op2, op3, ref cor3);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6113(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6122(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6123(textb, op1, op2, op3, ref cor3);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu3.actualizar_dia6131(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 2)
                                    waifu3.actualizar_dia6132(textb, op1, op2, op3, ref cor3);
                                else if (Booton == 3)
                                    waifu3.actualizar_dia6132(textb, op1, op2, op3, ref cor3);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
    
    public void cafe()
    {
        loli = 4;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = cafeteria;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = java;
        image.rectTransform.sizeDelta = new Vector2(300, 685);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia1(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia11(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia111(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia112(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia113(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia1131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia1132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia1133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia2(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia21(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia211(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia212(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia213(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia2131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia2132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia2133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia3(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia31(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia311(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia312(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia313(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia3131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia3132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia3133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia4(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia41(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia411(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia412(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia413(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia4131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia4132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia4133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia5(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia51(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia511(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia512(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia513(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia5131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia5132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia5133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu4.actualizar_dia6(textb, op1, op2, op3, ref cor4);
                        break;
                    case 2:
                        waifu4.actualizar_dia61(textb, op1, op2, op3, ref cor4);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu4.actualizar_dia611(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 2)
                            waifu4.actualizar_dia612(textb, op1, op2, op3, ref cor4);
                        else if (Booton == 3)
                            waifu4.actualizar_dia613(textb, op1, op2, op3, ref cor4);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6111(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6112(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6113(textb, op1, op2, op3, ref cor4);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6121(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6122(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6123(textb, op1, op2, op3, ref cor4);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu4.actualizar_dia6131(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 2)
                                    waifu4.actualizar_dia6132(textb, op1, op2, op3, ref cor4);
                                else if (Booton == 3)
                                    waifu4.actualizar_dia6133(textb, op1, op2, op3, ref cor4);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
   
    public void azotea()
    {
        loli = 5;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = entrada;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = python;
		image.rectTransform.sizeDelta = new Vector2(350, 685);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia1(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia11(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia111(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia112(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia113(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia1131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia1132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia1133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia2(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia21(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia211(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia212(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia213(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia2131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia2132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia2133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia3(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia31(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia311(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia312(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia313(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia3131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia3132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia3133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia4(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia41(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia411(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia412(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia413(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia4131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia4132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia4133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia5(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia51(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia511(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia512(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia513(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia5131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia5132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia5133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu5.actualizar_dia6(textb, op1, op2, op3, ref cor5);
                        break;
                    case 2:
                        waifu5.actualizar_dia61(textb, op1, op2, op3, ref cor5);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu5.actualizar_dia611(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 2)
                            waifu5.actualizar_dia612(textb, op1, op2, op3, ref cor5);
                        else if (Booton == 3)
                            waifu5.actualizar_dia613(textb, op1, op2, op3, ref cor5);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6111(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6112(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6113(textb, op1, op2, op3, ref cor5);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6121(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6122(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6123(textb, op1, op2, op3, ref cor5);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu5.actualizar_dia6131(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 2)
                                    waifu5.actualizar_dia6132(textb, op1, op2, op3, ref cor5);
                                else if (Booton == 3)
                                    waifu5.actualizar_dia6133(textb, op1, op2, op3, ref cor5);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }

    public void cancha()
    {
        loli = 6;
        Image image;
        ocultarbotonesmenu();
        mostraropciones();
        myimagecomponent = Fondo.GetComponent<Image>();
        myimagecomponent.sprite = gimnasio;
        textbox.active = true;
        chica.active = true;
        image = chica.GetComponent<Image>();
        image.sprite = ensamblador;
        image.rectTransform.sizeDelta = new Vector2(1100, 1000);

        switch (daycounter)
        {
            case 1:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia1(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia11(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia111(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia112(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia113(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia1111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia1113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia1121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia1121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia1131(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia1132(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia1133(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
            case 2:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia2(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia21(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia211(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia212(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia213(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia2131(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia2132(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia2112(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
            case 3:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia3(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia31(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia311(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia312(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia311(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia3111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia3112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia3113(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
            case 4:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia4(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia41(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia411(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia412(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia413(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia4131(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia4132(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia4133(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
            case 5:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia5(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia51(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia511(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia512(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia513(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia5131(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia5133(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia5133(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
            case 6:
                switch (momento)
                {
                    case 1:
                        waifu6.actualizar_dia6(textb, op1, op2, op3, ref cor6);
                        break;
                    case 2:
                        waifu6.actualizar_dia61(textb, op1, op2, op3, ref cor6);
                        break;
                    case 3:
                        if (Booton == 1)
                            waifu6.actualizar_dia611(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 2)
                            waifu6.actualizar_dia612(textb, op1, op2, op3, ref cor6);
                        else if (Booton == 3)
                            waifu6.actualizar_dia613(textb, op1, op2, op3, ref cor6);
                        break;
                    case 4:
                        switch (OldBooton)
                        {
                            case 1:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6111(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6112(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6113(textb, op1, op2, op3, ref cor6);
                                break;
                            case 2:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6121(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6122(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6121(textb, op1, op2, op3, ref cor6);
                                break;
                            case 3:
                                if (Booton == 1)
                                    waifu6.actualizar_dia6131(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 2)
                                    waifu6.actualizar_dia6133(textb, op1, op2, op3, ref cor6);
                                else if (Booton == 3)
                                    waifu6.actualizar_dia6133(textb, op1, op2, op3, ref cor6);
                                break;
                        }
                        break;
                }
                break;
        }
        if (momento > 4)
        {
            momento = 0;
            OldBooton = 0;
            Booton = 0;
            inicio();
        }
    }
}
