# Trabalho Avaliativo: do Flamenguista
NOME: Pedro DAvid Vieira RA: 126221446360
NOME: Victor Hugo Pedercine Costa RA: 126221444275

## 1. Laços de repetição

- Por que utilizamos laços de repetição?  
  Para automatizar tarefas repetitivas, reduzir a duplicação de código e percorrer estruturas de forma mais pratica e facil. *(Momento da auula: [03:45])*
- Qual é a diferença entre while e do-while?  
  O while avalia a condição antes de executar o bloco. Se ela for falsa, o bloco não será executado. O do-while executa o bloco pelo menos uma vez e só depois verifica a condição. Um exemplo são menus que precisam ser exibidos ao usuário pelo menos uma vez. *(Momento da aula:[12:30])*
- No exemplo dos times em C#, por que são necessários dois laços?  
  São necessários dois laços aninhados (mandante e visitante) para garantir que cada equipe jogue com todas as outras, gerando todas as combinações de confrontos.
- Qual é a função do if que impede um time de jogar contra si mesmo?  
  Ele verifica se os dos são iguais e ignora esse confronto, como  Flamengo x Flamengo.
- Quais são duas diferenças de sintaxe entre Java, C# e Rust? Que conceito lógico permanece igual?  
  - São declaradas com arrays em Java, List<T> em C# e Vec<String> em Rust.
  - A impressão usa System.out.println, Console.WriteLine e println.
  - Nas três linguagens, os laços percorrem os times para gerar os confrontos e evitar que um time jogue contra si mesmo.

## 2. Leitura e relação com o livro - capítulo 2

- Como os elementos de um array são organizados e acessados?  
  Eles ficam em fila e você os pega pelo número da posição, tipo uma ordem.
- Como uma lista encadeada é organizada?  
  A lista encadeada é uma corrente. Você só descobre onde está o próximo elemento olhando para o atual.
- Como funcionam inserções e exclusões em arrays e listas encadeadas?  
  Em um array, pode ser necessário deslocar elementos. Em uma lista encadeada, a operação pode ser feita alterando as referências entre os nós.
- Uma coleção chamada “lista” é necessariamente encadeada? (List<string> em C# e Vec<String> em Rust)  
  Não. Essas coleções usam arrays redimensionáveis armazenados em blocos contíguos de memória.
- Quais são as vantagens de estruturas baseadas em arrays para percorrer os times?  
  Acesso rápido por índice e uso eficiente da memória contígua.

## 3. Comparação de sintaxes

Ta no codigo.

## 4. Teste de mesa e validação

- Ta no codigo.

## 5. Comparação das Sintaxes

### Tabela Comparativa

| Operação | Java (Array) | C# (List) | Rust (Vec) |
| :--- | :--- | :--- | :--- |
| **Criar coleção** | `String[] times = {...};`[cite: 3, 5] | `List<string> times = new...;`[cite: 4, 5] | `let mut times = vec![...];`[cite: 4, 5] |
| **Ver tamanho** | `times.length`[cite: 5] | `times.Count`[cite: 5] | `times.len()`[cite: 5] |
| **Acessar índice** | `times[i]`[cite: 5] | `times[i]`[cite: 5] | `&times[i]`[cite: 5] |
| **Percorrer (`for`)** | `for (int i = 0; i < times.length; i++)`[cite: 5] | `for (int i = 0; i < times.Count; i++)`[cite: 5] | `for i in 0..times.len()`[cite: 5] |
| **Dois laços (`for` aninhados)** | `for(...) { for(...) {} }`[cite: 5] | `for(...) { for(...) {} }`[cite: 5] | `for i in ... { for j in ... {} }`[cite: 5] |
| **Evitar jogo contra si mesmo** | `if (i == j) continue;`[cite: 5] | `if (i == j) continue;`[cite: 5] | `if i == j { continue; }`[cite: 5] |
| **Adicionar 5º time** | Criar array novo e copiar[cite: 4, 5] | `times.Add("Tombense");`[cite: 4, 5] | `times.push("Tombense");`[cite: 4, 5] | Aqui a IA ajudou -_-

### O que mudou e o que ficou igual?

* **O que mudou (Sintaxe):** A forma de escrever de cada linguagem[cite: 5]. Cada uma usa um comando diferente para ver o tamanho (`.length`, `.Count`, `.len()`)[cite: 4, 5]. Além disso, C# e Rust adicionam itens facilmente com comandos prontos, enquanto o Java exige criar um novo array maior[cite: 4, 5].
* **O que ficou igual (Lógica):** O raciocínio para resolver o problema foi exatamente o mesmo nas três[cite: 5]: usar dois loops para cruzar os confrontos[cite: 4, 5], um `if` para o time não jogar contra si mesmo[cite: 4, 5], e `j = i + 1` para fazer o turno único[cite: 4].
  
## 6. Teste de Mesa 


### Resultados 

| Quantidade de Times | Jogos de Ida e Volta | Jogos em Turno Único |
| :---: | :---: | :---: |
| **3** | 6 | 3 |
| **4** | 12 | 6 |
| **5** | 20 | 10 |

---

###  Questão 6

1. **Por que a quantidade de combinações examinadas pode ser maior que a quantidade de jogos exibidos?**
   * Porque os laços aninhados percorrem litralnete todas as combinações possíveis do produto. No entanto, a condição de validação (`if (i == j) continue;`) tira os casos em que um time jogaria contra si mesmo. Por isso, testam-se 9 combinações com 3 times, mas exibem-se apenas 6 jogos

2. **O que acontece com a quantidade de confrontos quando acrescentamos um time?**
   * A quantidade de jogos cresce. 
   * Para **Ida e Volta**, a fórmula é $N \times (N - 1)$. Quando se passa para 5 times, o total de jogos salta de 12 para 20 
   * Para **Turno Único**, a fórmula é $\frac{N \times (N - 1)}{2}$. Ao passar de 4 para 5 times, o total de jogos salta de 6 para 10 

3. **As três linguagens produziram os mesmos jogos e totais?**
   * **Sim.** 