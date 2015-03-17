# PortaEletronica
O objetivo do exemplo é mostrar como tornar testável uma classe que faça uso da data/hora corrente.

Algumas considerações sobre o exemplo:

- Mostra como implementar um stub "do zero" ao invés de fazer uso de algum framework de mock.

- A dependencia (IProvedorDeHorario) é injetada via construtor. Em um projeto real, como muitos usos dessa dependencia pode ser interessante considerar a implementação do padrão Ambient Context (exemplo dessa estratégia no repositório "TimeProvider" - https://github.com/robsoncastilho/TimeProvider - recomendo a leitura do artigo citado no repositorio).

(Outras observações no próprio código.)
