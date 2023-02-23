Vamos imaginar uma variável como uma “caixinha etiquetada” de tamanho limitado. Podemos guardar nela somente um determinado tipo de conteúdo por vez, enquanto os outros valores são guardados durante o tempo de execução. Neste sentido, vamos variar de valor, mas jamais variar o tipo do conteúdo.

Anota aí 🖊: Ao criarmos uma variável, um espaço específico na memória RAM é reservado para manipulações de dados.

Veja na tabela abaixo quais os tipos de dados, também conhecidos como tipos primitivos e seus respectivos valores possíveis:

<strong>Tipo	Valores Possíveis</strong>
- bool	true e false
- byte	0 a 255
- sbyte	-128 a 127
- short	-32.768 a 32.767
- ushort	0 a 65.535
- int	-2.147.483.648 a 2.147.483.647
- uint	0 a 4.294.967.295
- long	-9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
- ulong	0 a 0 a 18.446.744.073.709.551.615
- float	Valores de ponto flutuante de até 7 dígitos. Ex: -3.402823e38 a 3.402823e38
- double	Valores de ponto flutuante de até 15 dígitos. Ex: -1.79769313486232e308 a 1.79769313486232e308
- decimal	Números com até 28 casas decimais. Ex: 0.991m, 33.333m
- char	Um unico caractere delimitado por aspas simples. Ex: ‘ç’,’M’,’f’

<br/><br/><br/><br/><br/>

<strong>Enum</strong>

As enumerações ou enum, como é chamado na linguagem C#, é um tipo de dado constante, fortemente tipado e estático, ou seja, não há necessidade de instanciar um objeto utilizando a palavra reservada new, seu acesso é feito a partir da estrutura em que o enum estiver contido. As enumerações possuem valores limitados a um conjunto de nomes simbólicos chamados elementos ou membros e não podem ser declaradas em métodos.

Este tipo de dado é útil quando há necessidade de representar algum conjunto de dados que não sofrerá tantas alterações no decorrer do desenvolvimento de um projeto, veja a seguir como declarar e utilizar um enum.

```
//Criando um enum
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};
//Utilizando um enum
CardinalPoints direction = CardinalPoints.Norte;
Console.WriteLine("Ponto Cardeal: "+direction);
```

<br /><br /><br />

<strong>Struct</strong>

Struct
O struct é uma alternativa mais leve do C# ao usar Class, por ser armazenado no stack da memória. Embora se pareça com a estrutura Class possui diferenças bem relevantes:

Não é possível herdar uma struct.
Não se pode ter construtores vazios.

```
//Criando uma struct
struct Schedule
{
    public int hour, minute, second;
    public string shift;
}

//utilizando uma struct
Schedule now;
now.hour = 10;
now.minute = 30;
now.shift = "AM";
Console.WriteLine("Horário: " + now.hour + ":" + now.minute + " " + now.shift);
```

Em uma struct é permitido que se utilize construtor e métodos

```
//Criando uma struct
struct Schedule
{
    private int hour, minute, second;
    private string shift;

    //Construtor da struct
    public Schedule(int hour, int minute, int second, string shif) 
    { 
        this.hour = hour % 24;
        this.minute = minute % 60;
        this.second = second % 60;
        this.shift = shif;
    }

    // metodo da struct
    public string getSchedule() 
    { 
        return hour.ToString()+ ":" + minute.ToString() + ":" + second.ToString()+" "+shift;
    }
}

//Incializando uma struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+ now.getSchedule());
```

Outra possibilidade permitida ao se utilizar struct é a capacidade de atribuir uma struct completa já inicializada para outra, veja a seguir:

```
//Criando uma struct
struct Schedule
{
    private int hour, minute, second;
    private string shift;

    //Construtor da struct
    public Schedule(int hour, int minute, int second, string shif) 
    { 
        this.hour = hour % 24;
        this.minute = minute % 60;
        this.second = second % 60;
        this.shift = shif;
    }
    // metodo da struct
    public string getSchedule() 
    { 
        return hour.ToString()+ ":" + minute.ToString() + ":" + second.ToString()+" "+shift;
    }
}

//Incializando uma struct com construtor
Schedule now = new Schedule(10,30,0,"AM");
Console.WriteLine("Horario: "+now.getSchedule());

//atribuindo uma struct iniciada para uma nova struct
Schedule now2 = now;
Console.WriteLine("Horario2: "+now2.getSchedule());
```

<br />
<br />
<br />

Outros tipos de dados que representam números inteiros

Tipo	Tamanho	Valor mínimo	Valor máximo
- sbyte	8-bit (signed)	-128	127
- byte	8-bit (unsigned)	0	255
- short	16-bit (signed)	-32768	32767
- ushort	16-bit (unsigned)	0	65535
- int	32-bit (signed)	-2147483648	2147483647
- uint	32-bit (unsigned)	0	4294967295
- long	64-bit (signed)	-9223372036854775808	9223372036854775807
- ulong	64-bit (unsigned)	0	18446744073709551615

<br /><br />

Trabalhando com ponto flutuante

De olho na dica👀: Quando criamos testes com números do tipo float podemos encontrar um problema bem recorrente! Em culturas específicas, os números do tipo float são representados com , e em outras é represetado com .. Com isso, precisamos definir qual cultura estamos usando no projeto .NET com a instrução:

```
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US", false);
```

Assim definimos uma cultura padrão como en-US e podemos usar números float como 10.33!
