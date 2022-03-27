#include <iostream>

using namespace std;

struct node
{
    struct node *next;
    struct node *child;
    string data;
};

void print_tree_r(struct node *node, int depth){
    int i;

    while (node)
    {
        if (node->child)
        {
            for(i=0; i < depth* 3; i++)
                cout << ' ';

            cout << '{' << endl;
            print_tree_r(node->child, depth + 1);

            for (i = 0; i < depth * 3; i++)
                cout << ' ';

            cout << '{' << endl;
            
            for (i = 0; i < depth * 3; i++)
                cout << ' ';

            cout << node->data.c_str() << endl;
        }
    }
    
}

void print_tree(node *root){
    print_tree_r(root, 0);
}
