import javax.swing.table.AbstractTableModel;
import java.sql.*;
//your table model class slightly modified
public class ReturnTableModel extends AbstractTableModel {
    //to issue a database command and store return value
    private Connection conn;
    private Statement stmt;
    private ResultSet resultSet;
    private ResultSetMetaData metaData;
    private int numberOfRows;
    //to throw exception
    private boolean connectedToDatabase = false;
    //need for refreshing
    private String Q;

    public ReturnTableModel(String driver, String url, String query) throws SQLException, ClassNotFoundException {
        Class.forName(driver);
        conn = DriverManager.getConnection(url);
        stmt = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
        connectedToDatabase = true;
        Q=query;
        // Run a query
        setQuery(query);
    }
    //re-run the select statement to update
    public void Refresh() throws SQLException {
        setQuery(Q);
    }

    //everything below are your original code
    public Class getColumnClass(int column) throws IllegalStateException {
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not Connected to Database");
        }

        try {
            String className = metaData.getColumnClassName(column + 1);

            return Class.forName(className);
        }
        catch (Exception e) {
            e.printStackTrace();
        }

        return Object.class;
    }

    @Override
    public int getColumnCount() throws IllegalStateException {
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not connected to database");
        }

        try {
            return metaData.getColumnCount(); // Return column count to caller
        }
        catch (SQLException e) {
            e.printStackTrace();
        }

        return 0; // Return nothing if there is nothing
    }

    public String getColumnName(int column) throws IllegalStateException {
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not connected to the database");
        }

        try {
            return metaData.getColumnName(column + 1); // Return name of the column
        }
        catch (SQLException e) {
            e.printStackTrace();
        }

        return ""; // Return empty string if problem occurs
    }


    @Override
    public int getRowCount() throws IllegalStateException{
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not connected to Database");
        }
        return numberOfRows;
    }

    @Override
    public Object getValueAt(int rowIndex, int columnIndex) throws IllegalStateException {
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not connected to Database");
        }

        try {
            resultSet.absolute(rowIndex + 1);
            return resultSet.getObject(columnIndex + 1);
        }
        catch (SQLException e) {
            e.printStackTrace();
        }

        return "";
    }

    public void setQuery(String query) throws SQLException, IllegalStateException {
        if(!connectedToDatabase) {
            throw new IllegalStateException("Not Connected to Database");
        }

        resultSet = stmt.executeQuery(query);
        metaData = resultSet.getMetaData();

        // Determine number of rows
        resultSet.last(); // Points to the last row of my resultSet
        numberOfRows = resultSet.getRow();

        // UPDATE OUR GUI
        fireTableStructureChanged(); // Signals to GUI components that resultSet has changed and that GUI will change
    }

    public void disconnectFromDatabase() {
        if(connectedToDatabase) {
            try {
                resultSet.close();
                stmt.close();
                conn.close();
            }
            catch(SQLException e) {
                e.printStackTrace();
            }
            finally {
                connectedToDatabase = false;
            }
        }
    }
}

