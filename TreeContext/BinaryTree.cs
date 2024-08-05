namespace DayFive.TreeContext
{
  public class BinaryTree
  {
    private TreeNode Root;

    public BinaryTree()
    {
      Root = null;
    }
    public void Insert(int value)
    {
      TreeNode newNode = new TreeNode(value);

      if (Root == null)
      {
        Root = newNode;
        return;
      }

      TreeNode current = Root;
      TreeNode parent = null;

      while (true)
      {
        parent = current;
        if (value < current.Value)
        {
          current = current.Left;
          if (current == null)
          {
            parent.Left = newNode;
            return;
          }
        }
        else if (value > current.Value)
        {
          current = current.Right;
          if (current == null)
          {
            parent.Right = newNode;
            return;
          }
        }
        else
        {
          return;
        }
      }
    }
    public bool Search(int value)
    {
      TreeNode current = Root;

      while (current != null)
      {
        if (value == current.Value)
        {
          return true;
        }
        else if (value < current.Value)
        {
          current = current.Left;
        }
        else
        {
          current = current.Right;
        }
      }

      return false;
    }
     public void PrintTree()
    {
        if (Root == null)
        {
            Console.WriteLine("A árvore está vazia.");
            return;
        }

        PrintTree(Root, "", true);
    }
    private void PrintTree(TreeNode node, string indent, bool last)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("└── ");
                indent += "    ";
            }
            else
            {
                Console.Write("├── ");
                indent += "│   ";
            }

            Console.WriteLine(node.Value);
            PrintTree(node.Left, indent, false);
            PrintTree(node.Right, indent, true);
        }
    }
  }
}