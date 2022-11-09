package Controller;

import View.Cadastro;
import View.Menu;
import java.util.ArrayList;
import Model.Funcionarios;
import Model.DAO;
import View.Lista;

public class Main {

    public static void main(String[] args) {
        /*
        dao banco = new dao();
        
        ArrayList<Funcionarios> lista = banco.listarFuncionarios();
        
        for(int i=0; i < lista.size();i++){
            System.out.println("ID: "+lista.get(i
            ).getID());
            System.out.println("Nome: "+lista.get(i).getNome());
            System.out.println("Email: "+lista.get(i).getEmail());
            System.out.println("Cargo: "+lista.get(i).getCargo());
        }
        banco.inserirFuncionario(new Funcionarios(0,"Luiz Inacio","inaz@gmail","Futuro Presidente"));        
        //banco.inserirFuncionario(new Funcionarios(0,"Luiz Inacio","inaz@gmail","Futuro Presidente"));
        */
        
        //-------------------------------------------------------
        Controller c = new Controller(new Menu(), new Cadastro(), new Lista());
        c.initController();
        
    }
}
