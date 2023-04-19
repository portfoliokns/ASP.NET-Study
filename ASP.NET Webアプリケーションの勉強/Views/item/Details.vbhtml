@ModelType ASP.NET_Webアプリケーションの勉強.t_item
@Code
    ViewData("Title") = "Details"
End Code

<h2>商品詳細ページ</h2>

<div>
    <h4>商品詳細</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @ViewBag.japanese.item_name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ItemName)
        </dd>

        <dt>
            @ViewBag.japanese.registration_date
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RegistrationDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("編集", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("戻る", "Index")
</p>
