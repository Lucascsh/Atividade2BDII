package Model;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.sql.*;

public class DAO {
    private String url = "jdbc:mysql://localhost:3306/Atividade_Agendamento";
    private String driver = "com.mysql.cj.jdbc.Driver";
    private String user = "root";
    private String password = "laboratorio";
    
    private Connection conectar(){
        Connection com = null;
        try{
            Class.forName(driver);
            com = DriverManager.getConnection(url, user, password);
            return com;
        }catch(Exception e){
            System.out.println(e);
            return null;
        }
    } 
    
    public ArrayList<Funcionarios> listarFuncionarios(){
        ArrayList<Funcionarios> listaFuncionarios = new ArrayList<>();
        String read = "select * from Funcionarios;";
        try{
            Connection con = conectar();
            PreparedStatement pst = con.prepareStatement(read);
            
            ResultSet rs = pst.executeQuery();
            while(rs.next()){
                int id = Integer.parseInt(rs.getString(1));
                String nome = rs.getString(2);
                String email = rs.getString(3);
                String cargo = rs.getString(4);
                
                listaFuncionarios.add(new Funcionarios(id,nome,email,cargo));
            }
            con.close();
            return listaFuncionarios;
            
        }catch(Exception e){
            System.out.println(e);
            return null;
        }
    }
    
    public void inserirFuncionario(Funcionarios func){
        String insert = "insert into funcionarios values(null, ?, ?, ?)";
        try{
            Connection con = conectar();
            
            PreparedStatement pst = con.prepareStatement(insert);
            
            pst.setString(1, func.getNome());
            pst.setString(2, func.getEmail());
            pst.setString(3, func.getCargo());
            
            pst.execute();
            
            System.out.println("Usuário inserido");
            
            con.close();
            
        }catch(Exception e){
            System.out.println("ERRO AO INSERIR");
        }
    }
}
