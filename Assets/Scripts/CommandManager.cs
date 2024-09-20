using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public interface ICommand
{
    void Execute();
    void Undo();
}
public class MoveCommand : ICommand 
{
    private Transform objectToMove;
    private Vector3 displacement;

    public MoveCommand(Transform obj,Vector3 displacement)
    {
        this.objectToMove = obj;
        this.displacement = displacement;
    }
    public void Execute() { objectToMove.position += displacement; }
    public void Undo() { objectToMove.position -= displacement; }
}
public class CommandManager : MonoBehaviour
{
    private Stack<ICommand> commandHistory = new Stack<ICommand>();         //���� �ڷᱸ�� ���¤Ǥ� Ŀ�ǵ� ����

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        commandHistory.Push(command);                                       //Stack�� �ִ´�
    }
    public void UndoLastCommand()
    {
        if(commandHistory.Count > 0)
        {
            ICommand lastCommand = commandHistory.Pop();                    //Stack���� ������.
            lastCommand.Undo();
        }
    }
}
