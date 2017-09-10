/*
    通用方法集合
*/
public class utilMath {
    //Global.GetInstance().test(1)

    public string loadName;
    private static utilMath instance;  

    public static utilMath GetInstance()
    {
        if (instance == null)  
            instance = new utilMath();
        return instance;
    }

/*    public int GetTableLength(string tab)
    {
        int a = 0;
        foreach (string j in tab )
        {
            a += 1;
        }
        return a;
    }*/

    

    /*--获取节点的table树结构
    function Func_get_node_tree(tb,node)
       
        local children = node:getChildren()
        local len = table.getn(children)
        for i=1,len do
            local name = children[i]:getName() 
            if name ~= nil and name ~= "" then
                tb[name] = children[i]
                Func_get_node_tree(tb[name],tb[name])
            end
        end
    end*/
}  