using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //display selected node
    protected void tvCarBrands_SelectedNodeChanged(object sender, EventArgs e)
    {
        tbDisplay.Text = "selected node:" + tvCarBrands.SelectedNode.Text +"\nIts Child Nodes:\n" ;

 
        foreach (TreeNode nodes in tvCarBrands.SelectedNode.ChildNodes)
        {
            tbDisplay.Text += nodes.Text +"\n";
           
          
        }
    }

    //add a node
    protected void btnAddNode_Click(object sender, EventArgs e)
    {
        TreeNode newnode = new TreeNode();
        newnode.Text = "NEW NODE";
        newnode.Selected = true;
        newnode.NavigateUrl = "https://www.google.com";

        tvCarBrands.Nodes.Add(newnode);
    }

    //remove a node
    protected void btnRemoveNode_Click(object sender, EventArgs e)
    {
        TreeNode node = tvCarBrands.SelectedNode;
        tvCarBrands.Nodes.Remove(node);
    }

    //modify node 

    protected void btnModifyNode_Click(object sender, EventArgs e)
    {
        TreeNode node = tvCarBrands.SelectedNode;
        node.Text = "MODIFIED";

    }

    //expand node/collapse node
    protected void btnExpand_Click(object sender, EventArgs e)
    {
        TreeNode node = tvCarBrands.SelectedNode;
        if (node.ChildNodes.Count > 0)
        {
            node.Expanded = true;
        }
        else
        {
            tbDisplay.Text = "No child nodes";
        }
    }
    protected void btnCollapse_Click(object sender, EventArgs e)
    {
        TreeNode node = tvCarBrands.SelectedNode;
        //node.Expanded = false;
        node.Collapse();

    }

    protected void dataList_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbDisplay.Text = "Selected";
    }
}