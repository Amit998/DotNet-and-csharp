using System;

namespace Tree
{
    class NTree
    {
        Node top;
        int level;
        dynamic rootNode;

        public NTree()
        {
            this.level = 0;
            top = null;
        }
        public NTree(dynamic initial)

        {
            rootNode = initial;
            top = new Node(initial);
        }

        public int get_asci_value_of_string(string value)
        {
            int total = 0;

            foreach (var c in value)
            {
                total += (int)c;
            }

            return total;
        }


        /*   public void Add(dynamic value)
           {
               if (top == null)
               {
                   Node newNode = new Node(value);
                   top = newNode;
                   return;
               }

               //int tempValue = get_asci_value_of_string(value);

               Node currentNode = top;
               bool added = false;
               Console.WriteLine(value+"  "+ currentNode.value);

               do
               {

                   if (value < currentNode.value)
                   {
                       if (currentNode.left == null)
                       {
                           Node newNode = new Node(value);
                           currentNode.left = newNode;
                           added = true;
                       }
                       else
                       {
                           currentNode = currentNode.left;
                       }
                   }
                   if (value >= currentNode.value)
                   {
                       if (currentNode.right == null)
                       {
                           Node newNode = new Node(value);
                           currentNode.right = newNode;
                           added = true;
                       }
                       else
                       {
                           currentNode = currentNode.right;
                       }

                   }
               } while (!added);


           }

   */
        public void AddRc(dynamic value)
        {
            try
            {
                //Console.WriteLine(contains(value) + " check this");
                if (contains(value))
                {
                    throw new CustomException("Already exists");
                }
                AddR(ref top, value);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node newNode = new Node(value);
                N = newNode;
                return;
            }
            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            if (value >= N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public Node deleteRec(Node root, int key)
        {
            if (root == null)
            {
                return root;
            }

            if (key < root.value)
            {
                root.left = deleteRec(root.left, key);
            }
            else if (key > root.value)
            {
                root.right = deleteRec(root.right, key);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)

                    return root.left;


                root.value = minValue(root.right);
                root.right = deleteRec(root.right, root.value);
            }

            return root;
        }

        int minValue(Node root)
        {
            int minv = root.value;

            while (root.left != null)
            {
                minv = root.value;
                while (root.left != null)
                {
                    minv = root.left.value;
                    root = root.left;
                }
            }

            return minv;
        }
        public bool contains(int value)
        {
            Node root = top;
            bool flag = false;
            containRec(root, value, ref flag);
            return flag;
        }

        public bool containRec(Node root, int value, ref bool flag)

        {
            if (root == null)
            {
                return false;
            }

            else if (root != null)
            {
                if (root.value == value)
                {
                    flag = true;

                }

                containRec(root.left, value, ref flag);
                containRec(root.right, value, ref flag);
            }
            return flag;

            /*if(root.value == value)
            {
                return true;
            }
            else if(root.left != null)
            {
                containRec(root.left, value);
                
            }else if (root.right != null)
            {
                containRec(root.right, value);
            }*/


        }
        public void delete(int key)
        {
            Node root = top;

            try
            {
                if (root == null)
                {
                    throw new CustomException("Empty Tree");
                }
                if (!contains(key))
                {
                    throw new CustomException("unable to find");
                }

                top = deleteRec(root, key);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /*public void printRe()
        {

            string myStr = "";
            Print(null, ref myStr);
            Console.WriteLine(myStr);
        }*/



        /*public void Print(Node N, ref string s)
        {


            if (N == null)
            {
                N = top;
            }
            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString() + "-";
            }
            else
            {
                s = s + N.value.ToString() + "-";
            }
            if (N.right != null)
            {
                Print(N.right, ref s);
            }
        }
*/
        /*public void inorder()
        {
            inorderRec(top);
            Console.WriteLine('\n');
        }

        public void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.Write(root.value + "-");
                inorderRec(root.right);
            }

        }*/

        public void getLeve()
        {
            Console.Write(level);
        }
        public int height()
        {


            return heightHelper(top);
        }
        public int heightHelper(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int left_height = heightHelper(node.left);
                int right_height = heightHelper(node.right);

                if (left_height > right_height)
                {
                    return left_height + 1;
                }
                else
                {
                    return right_height + 1;
                }
            }
        }

        public void DFS()
        {
            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Tree");
                }

                /* inorder,preorder,postorder */
                string inorderString = "";
                string preorderString = "";
                string postOrderString = "";
                Console.WriteLine("\nDFS");
                Node node = top;
                Console.WriteLine("Inorder");
                inOrder(node, inorderString);
                Console.WriteLine("\n prorder");
                preOrder(node, preorderString);
                Console.WriteLine("\n Postorder");
                postOrder(node, postOrderString);


            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void BFS()
        {
            Node node = top;

            try
            {
                if (node == null)
                {
                    throw new CustomException("Empty Tree");
                }

                Console.WriteLine("BFS");
                levelOrderTraversal(node);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public void inOrder(Node node, string inorderString)
        {
            if (node == null)
            {
                return;
            }

            inOrder(node.left, inorderString);
            Console.Write(node.value + "->");
            inOrder(node.right, inorderString);

        }

        public void preOrder(Node node, string preOrderString)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.value + "->");
            preOrder(node.left, preOrderString);
            preOrder(node.right, preOrderString);
        }

        public void postOrder(Node node, string postOrderString)
        {

            preOrder(node.left, postOrderString);
            preOrder(node.right, postOrderString);
            Console.Write(node.value + "->");
        }



        public string get_level_value(int level)
        {
            string levelString = "";


            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Tree");
                }

                currentLevelValue(top, level, ref levelString);

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return levelString;


        }

        public dynamic currentLevelValue(Node node, int level, ref string levelString)
        {

            if (node == null)
            {
                return 0;
            }
            if (level == 1)
            {
                levelString += node.value.ToString() + "+";
                //Console.WriteLine(node.value );
                return node.value;

            }
            else if (level > 1)
            {
                currentLevelValue(node.left, level - 1, ref levelString);
                currentLevelValue(node.right, level - 1, ref levelString);
            }

            return null;

        }

        public void get_element_value(int value)
        {
            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Tree");
                }

                if (contains(value))
                {
                    string element = "";
                    bool flag = false;


                    Console.WriteLine("hi");

                    Node node = top;
                    get_element_value_helper(node, ref element, ref flag, value);
                    Console.WriteLine(element);
                }

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void get_element_value_helper(Node node, ref string element, ref bool flag, int value)
        {

            if (node == null)
            {
                return;
            }

            if (flag == true)
            {
                element += "->" + node.value;
            }

            if (node.value == value)
            {
                flag = true;
            }
            get_element_value_helper(node.left, ref element, ref flag, value);
            get_element_value_helper(node.right, ref element, ref flag, value);

        }



        public Node get_main_Node()
        {
            return top;
        }

        public Queue get_node_dfs()
        {
            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Tree");
                }

                string element = "";

                Node node = top;
                get_str_from_node_dfs_helper(node, ref element);
                Queue temp = new Queue();
                temp = get_queue_from_string(element);
                return temp;
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void get_str_from_node_dfs_helper(Node node, ref string element)
        {
            if (node == null)
            {
                return;
            }


            get_str_from_node_dfs_helper(node.left, ref element);
            get_str_from_node_dfs_helper(node.right, ref element);

        }




        public Queue get_node_bfs()
        {
            try
            {
                if (top == null)
                {
                    throw new CustomException("Empty Tree");
                }

                string element = "";

                Node node = top;
                get_str_from_node_bfs_helper(node, ref element);
                Queue temp = new Queue();
                temp = get_queue_from_string(element);
                return temp;
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void get_str_from_node_bfs_helper(Node node, ref string element)
        {
            if (node == null)
            {
                return;
            }


            for (int i = 1; i <= height(); i++)
            {
                element += "+" + get_level_value(i);
            }

        }



        public Queue get_queue_from_string(string str_temp)
        {
            Queue queueTest = new Queue();

            foreach (dynamic s in str_temp.Split("+", StringSplitOptions.None))
            {

                if (s != "")
                {
                    queueTest.enqueue(s);
                }
            }

            return queueTest;

        }

        public void levelOrderTraversal(Node node)
        {
            Queue queueTest = new Queue();


            string str = "";


            for (int i = 1; i <= height(); i++)
            {
                str += get_level_value(i);
            }


            foreach (dynamic s in str.Split("+", StringSplitOptions.None))
            {

                if (s != "")
                {
                    queueTest.enqueue(s);
                }
            }


            while (!queueTest.isEmpty())
            {
                Console.Write(queueTest.deQueue() + "->");

            }

        }
    }


    class iteratorBfs
    {

        Node mainNode;

        public iteratorBfs(Node node)
        {
            this.mainNode = node;
        }

        public Node next(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.value);
                return node.left;
            }
            else
            {
                Console.WriteLine("Empty Node");
                return null;
            }
        }

        public string get_level_value(int level)
        {
            string levelString = "";
            return levelString;

        }

        public Node reset()
        {

            return mainNode;
        }

    }

    class iteratorDfs
    {
        Node mainNode;

        public iteratorDfs(Node node)
        {
            this.mainNode = node;
        }

        public Node next(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.value);
                return node.left;
            }
            else
            {
                Console.WriteLine("Empty Node");
                return null;
            }
        }
        public void inOrder(Node node, string inorderString)
        {
            if (node == null)
            {
                return;
            }

            inOrder(node.left, inorderString);
            Console.Write(node.value + "->");
            inOrder(node.right, inorderString);

        }

        public int preOrder(Node node, string preOrderString)
        {
            if (node == null)
            {
                return 0;
            }

            return node.value;
            preOrder(node.left, preOrderString);
            preOrder(node.right, preOrderString);
        }

        public int postOrder(Node node, string postOrderString)
        {

            preOrder(node.left, postOrderString);
            preOrder(node.right, postOrderString);
            return node.value;
        }

        public Node reset()
        {

            return mainNode;
        }

    }
}

/*get_element_value*/