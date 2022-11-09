
package View;

import Model.DAO;
import Model.Funcionarios;
import java.util.ArrayList;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;


public class Lista extends javax.swing.JFrame {

    
    public Lista() {
        initComponents();
        DAO dao = new DAO();
        
        ArrayList<Funcionarios> lista = dao.listarFuncionarios();
        
        DefaultTableModel model = ((DefaultTableModel) jTFunc.getModel());
        
        for (var funcionarios : lista) {
            model.addRow( new String[] {
                          funcionarios.getID()+"",
                          funcionarios.getNome(),
                          funcionarios.getEmail(),
                          funcionarios.getCargo()
                } );
        }
        
    }

    public JButton getjBMenu2() {
        return jBMenu2;
    }


    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jBMenu2 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTFunc = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setText("Lista de Funcionarios");

        jBMenu2.setText("MENU");

        jTFunc.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "ID", "Nome", "Email", "Cargo"
            }
        ));
        jScrollPane1.setViewportView(jTFunc);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 465, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jBMenu2)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(layout.createSequentialGroup()
                .addGap(182, 182, 182)
                .addComponent(jLabel1)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 275, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 33, Short.MAX_VALUE)
                .addComponent(jBMenu2)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    

   

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jBMenu2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTFunc;
    // End of variables declaration//GEN-END:variables
}
