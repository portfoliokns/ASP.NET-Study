@ModelType ASP.NET_Webアプリケーションの勉強.t_item
@Code
    ViewData("Title") = "Delete"
End Code

<h2>削除ページ</h2>

<h3>※警告※　本当に削除しますか？</h3>
<div>
    <h4>商品情報</h4>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="削除" class="btn btn-default" /> |
            @Html.ActionLink("戻る", "Index")
        </div>
    End Using
</div>
