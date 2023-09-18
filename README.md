
# Jogo da Forca em C#

Projeto desenvolvido durante o curso de C# da ADA, módulo Lógica de Programação I.

## Descrição
O jogo da forca é um jogo em que o jogador tem que acertar qual é a palavra proposta, tendo como dica o número de letras e o tema ligado à palavra. A cada letra errada, é desenhada uma parte do corpo do enforcado. O jogo termina ou com o acerto da palavra ou com o término do preenchimento das partes corpóreas do enforcado.

**Desafio:** Durante a execução do programa, o jogador deve escrever uma letra na linha de comando. Caso a letra exista na palavra-chave, o jogo deve imprimir a letra digitada na posição correspondente. Caso contrário, o jogo deve imprimir em tela a mensagem "A letra digitada não existe na palavra-chave" e exibir o total de erros. A classe que encapsula a lógica do jogo contém métodos para verificar se a letra existe na palavra-chave, se o jogador completou a palavra-chave e se a quantidade máxima de tentativas foi atingida. Nota: Pode-se imprimir em tela o desenho do corpo do enforcado conforme a evolução do jogo ou apenas informar a quantidade de tentativas restantes.

## Como executar

1. **Clonar o repositório:**
   ```bash
   git clone https://github.com/PauloEwerson/Jogo_da_forca.git
   ```

2. **Navegar até o diretório do projeto:**
   ```bash
   cd Jogo_da_forca
   ```

3. **Compilar o código (assegure-se de que você tenha o compilador C# instalado):**
   ```bash
   csc Program.cs Forca.cs
   ```

4. **Executar o programa:**
   ```bash
   ./Program.exe
   ```

Agora, você pode jogar o Jogo da Forca! =D
