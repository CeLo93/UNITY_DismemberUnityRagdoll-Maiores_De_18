<p align="center"> 
:construction: <b> PROJETO EM CONSTRUÇÃO </b> :construction: 
<p>

> Sistema de desmembramento por Raycast. Funciona com uma interação simples entre classes ligadas aos prefabs que serão delatados e substituídos e o sistema de FPS tradicional com uso do Raycast

> Favor não usar os prefabs originais do modelo para uso comercial, pois são apenas de referência. Use-o como referência e elabore facilmente no Blender, por exemplo.


<p align="center"> 
:smile: <b> step by step :smile: </b>
<p>

```mermaid
graph LR
A[1-Implementar Ragdoll no modelo]
B[2-Ajustar Colisores]
C[3-Anexar os Scripts]--Enemy-->C1[[3.1-Anexar no prefab swat]]
C--Limb-->C2[[3.2-Anexar nos membros respectivos do swat]]
D[[4-Anexar os prefabs às referências do script Limb]]
E[5-Inserir o prefab controller FPS na scene]
A-->B-->C
C1-->D
C2-->D
D-->E

```
 
 ______________________________________________________________________________________________________

 
![1](https://github.com/CeLo93/DismemberUnityRagdoll-/blob/main/i1.png)

<p align="center"> (Imagem - 01: Frame do sistema)<p>

______________________________________________________________________________________________________


https://user-images.githubusercontent.com/92175791/206196030-28984c78-9a6a-4ad5-b546-de00073d571c.mp4

<p align="center"> (Video - 01: Sistema em ação)<p>

______________________________________________________________________________________________________
