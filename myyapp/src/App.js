import DisplayStudents from './Component/DisplayStudents'
import './App.css';
import Delete from './Component/Delete';
import InsertStudents from './Component/InsertStudents';

function App() {
  return (
    <div>
      <DisplayStudents/>
      <InsertStudents/>
      <Delete/>
    </div>
  );
}

export default App;
