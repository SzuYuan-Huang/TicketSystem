## Diagram
1. Phase 1 (https://docs.google.com/drawings/d/140lgOuxYgVE1JZTe_Bfbr-ICd5e1U1IjnGR9AJ7NmnM/edit?usp=sharing)
2. Phase 2 ()

## Data Model
<img src="./Table Schema.png">

## 資料表介紹
1. User (人員)
   - User_Id (序號)
   - User_Name (名稱)
   - User_Account (帳戶)
   - User_Password (密碼)
   - User_RoleId (角色序號)
     - 此欄位控管人員對應角色是誰，而影響可用的功能
2. Role (角色)
   - Role_Id (序號)
   - Role_Name (名稱)
     - 此欄位定義人員角色的歸類，如 RD、QA 等
3. SystemFunction (系統功能)
   - SystemFunction_Id (序號)
   - SystemFunction_Name (名稱)
4. SystemFunctionRoleMapping (系通功能對應可用的角色)
   - SystemFunctionRoleMapping_Id (序號)
   - SystemFunctionRoleMapping_RoleId (角色序號)
   - SystemFunctionRoleMapping_SystemFunctionId (系統功能序號)
5. Ticket (工單)
   - Ticket_Id (序號)
   - Ticket_Title (標題)
   - Ticket_Description (描述)
   - Ticket_TypeDef (類型)
   - Ticket_StatusDef (狀態)
   - Ticket_AssignUserId (指派人員序號)
     - 因操作人員建立工單時，需要指派哪位人員處理事情顧提供此欄位紀錄
   - Ticket_CreatedUserId (建立人員序號)
     - 此欄位提供人員在建立時記錄當下是誰，方便被指派的人員可以有依據知道誰指派的任務

## API 文檔 (Not yet)
