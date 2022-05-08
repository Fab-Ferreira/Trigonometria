# Trigonometria
## Introdução
Olá! Meu nome é Fabrício e estudo na ETEC de Taboão da Serra, cursando Desenvolvimento de Sistemas. Este é meu primeiro programa que estou postando no GitHub e trata-se de um programa que calcula trigonometria através dos valores inseridos pelo usuário. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

## Funcionalidade do Programa
O usuário, ao iniciar o programa, precisa preencher 4 text boxes que estão na tela, sendo eles: **Lado A (hipotenusa), Lado B (cateto oposto), Lado C (cateto adjacente) e o Ângulo**. Nas três primeiras text boxes, o usuário deverá inserir um número (valor de um dos lados já conhecido), uma letra **x** (valor de um dos lados a ser descoberto) e um asterísco (\*, valor de um dos lados que não precisa ser descoberto e nem tem valor) em qualquer um dos três lados. Já na TextBox escrita *Angle*, você precisa inserir um número entre 1 à 89. Através dos dados inseridos, o programa irá observar qual das três funções trigonométricas (Seno, Cosseno e Tangente) deve ser usado para o cálculo.

Para que o programa utilize a função:
- **Seno (cateto oposto / hipotenusa)**, deve ser inserido um \* no lado **C**, e um número e a letra **x** nos lados **A** e **B**;
- **Coseno (cateto adjacente / hipotenusa)**, deve ser inserido um \* no lado **B**, e um número e a letra **x** nos lados **A** e **C**;
- **Tangente (cateto oposto / cateto adjacente)**, deve ser inserido um \* no lado **A**, e um número e a letra **x** nos lados **B** e **C**.

Após inserir os respectivos valores e clicar no botão de Calcular, através de uma classe externa, será feito um cálculo dependendo da posição dos valores e será retornado para a tela através de uma TextBox no canto inferior da tela.
&nbsp;

## Atenção!
- Evite de clicar no botão com as Text Boxes sem texto ou com caracteres inválidos;
- O programa só permite o uso de números acima de 0;
- O resultado retornado sempre estará na forma de decimal.

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
