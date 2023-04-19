@ModelType IEnumerable(Of ASP.NET_Webアプリケーションの勉強.t_item)
@Code
    ViewData("Title") = "index"
End Code

<h2>商品一覧</h2>

<p>
    @Html.ActionLink("新規追加", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @ViewBag.japanese.item_name
        </th>
        <th>
            @ViewBag.japanese.registration_date
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ItemName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.RegistrationDate)
        </td>
        <td>
            @Html.ActionLink("編集", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("詳細", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("削除", "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
