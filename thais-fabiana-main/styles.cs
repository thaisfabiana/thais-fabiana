@import url(‘https://fonts.googleapis.com/ css2?family=Chakra+Petch:wght@400;700&display=swap’);
:root { 
    --cor-de-fundo: #1E1E1E; 
    --verde: #6FFF57; 
    --branco: #FFFFFF; 
    --botao-ativo: #3A375E; 
    --botao-inativo: rgba(58, 55, 94, 0.5); 
    --texto-fundo: rgba(58, 55, 94, 0.3); 
    }
body {
    background-color: var(--cor-de-fundo);
    color: var(--branco); 
    font-family: ‘Chakra Petch’, sans-serif;
    }
.conteudo-principal { 
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    max-width: 1200 px;
    width: 100%;
    margin: 0 auto;
    }
.titulo-principal { text-align: left;
    width: 100%;
    font-size: 32 px;
}