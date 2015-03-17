# PortaEletronica
Exemplo de uso de um stub para eliminar a dependência de DateTime e possibilitar que a classe que precisa de data/hora seja testável.

Algumas considerações sobre o exemplo:

- Mostra como implementar um stub "do zero" ao invés de fazer uso de algum framework de mock.

- A dependencia (IProvedorDeHorario) é injetada via construtor. Em um projeto real, como muitos usos dessa dependencia pode ser interessante considerar a implementação do padrão Ambient Context (exemplo dessa estratégia no repositório "TimeProvider" - recomendo a leitura do artigo correspondente).
