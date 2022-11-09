
package Controller;

import View.Cadastro;
import View.Menu;
import Model.DAO;
import Model.Funcionarios;
import View.Lista;


public class Controller {
    private Menu menu;
    private Cadastro cadastro;
    private Lista lista;
    private DAO dao = new DAO();

    public Controller(Menu menu, Cadastro cadastro, Lista lista) {
        this.menu = menu;
        this.cadastro = cadastro;
        this.lista = lista;
    }
    
    
    
    
    public void initController(){
        menu.setVisible(true);
        menu.getjBCadastro().addActionListener(e->exibirTelaCadastro());
        cadastro.getjBMenu().addActionListener(e->exibirTelaMenu());
        //salvar: renomer ele
        cadastro.getjBSalvar().addActionListener(e -> salvarFuncionario());
        menu.getjBLista().addActionListener(e -> exibirTelaLista());
        lista.getjBMenu2().addActionListener(e->exibirTelaMenu());
    }
    
    private void salvarFuncionario(){
        dao.inserirFuncionario(new Funcionarios(cadastro.getjTFNome().getText(), 
                                             cadastro.getjTFEmail().getText(),
                                             cadastro.getjTFCargo().getText()));
    }
    
    private void exibirTelaMenu(){
        menu.setVisible(true);
        cadastro.setVisible(false);                  
    }
     
    private void exibirTelaCadastro(){
        cadastro.setVisible(true);
        menu.setVisible(false);              
    }
    
    private void exibirTelaLista(){
        lista.setVisible(true);
        menu.setVisible(false);
        
    }
}
