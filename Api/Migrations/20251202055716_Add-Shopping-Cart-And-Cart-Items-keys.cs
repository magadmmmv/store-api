using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartAndCartItemskeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Качественно другой различных существующий нас условий выбранный.", "Свободный Бетонный Кошелек", 737.35000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Предпосылки консультация систему всего насущным гражданского высшего постоянный изменений.", "Эргономичный Неодимовый Свитер", 445.19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сложившаяся активности формирования поэтапного национальный для понимание эксперимент однако.", "Практичный Деревянный Носки", 954.86000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Занимаемых высшего повышение собой практика изменений обучения участниками.", "Потрясающий Пластиковый Портмоне", 947.72000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Дальнейших показывает развития.", "Большой Стальной Ботинок", 436.25999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Формирования проверки демократической напрямую.", "Эргономичный Пластиковый Стол", 715.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Особенности уровня понимание также модель начало богатый представляет нас повышению.", "Интеллектуальный Деревянный Ножницы", 644.98000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "В этих равным широким.", "Практичный Меховой Кепка", 982.05999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Не забывать новых работы рамки роль путь.", "Великолепный Кожанный Автомобиль", 619.91999999999996, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Существующий путь принципов роль обеспечивает консультация повышению начало нас.", "Грубый Резиновый Майка", 200.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Модель форм за.", "Эргономичный Меховой Стул", 852.17999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Влечёт существующий стороны укрепления за.", "Великолепный Бетонный Плащ", 713.10000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Выбранный другой широким внедрения плановых и сущности структуры.", "Грубый Натуральный Ремень", 514.09000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Настолько нашей проблем за и.", "Большой Стальной Свитер", 889.38999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Прежде количественный настолько обучения процесс насущным подготовке.", "Грубый Резиновый Куртка", 133.53999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "По очевидна технологий активом создание технологий предложений порядка выполнять.", "Невероятный Меховой Плащ", 254.47999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Курс по оценить.", "Грубый Деревянный Автомобиль", 480.06999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Материально-технической активизации повышение реализация проблем обуславливает экономической.", "Практичный Натуральный Автомобиль", 605.05999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Кадров соответствующих значимость рост сложившаяся на насущным внедрения играет забывать.", "Грубый Меховой Ножницы", 966.91999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Общественной процесс новая что насущным.", "Грубый Бетонный Портмоне", 122.79000000000001, "Новинка" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Различных материально-технической уточнения существующий формированию.", "Потрясающий Резиновый Кулон", 873.63, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Анализа важные путь обуславливает воздействия нами отношении порядка забывать.", "Фантастический Резиновый Кепка", 493.76999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Инновационный воздействия воздействия же шагов понимание сложившаяся принимаемых.", "Потрясающий Кожанный Ремень", 894.80999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Постоянный внедрения существующий современного задания богатый повышению прогрессивного рамки забывать.", "Большой Кожанный Кепка", 478.38999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Социально-ориентированный массового способствует формированию значимость.", "Интеллектуальный Бетонный Ремень", 177.0, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Дальнейшее место также гражданского.", "Большой Неодимовый Ремень", 452.64999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Значительной поэтапного концепция влечёт проблем высокотехнологичная изменений на.", "Потрясающий Меховой Автомобиль", 632.91999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Существующий требует структура обучения анализа последовательного.", "Свободный Кожанный Свитер", 61.140000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Обеспечение требует богатый.", "Потрясающий Гранитный Куртка", 450.66000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Проект различных повседневная обеспечивает зависит активности постоянный широким опыт.", "Фантастический Меховой Куртка", 57.939999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Позволяет этих обеспечение.", "Лоснящийся Резиновый Автомобиль", 702.24000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Изменений обществом проверки уровня понимание демократической этих.", "Эргономичный Хлопковый Куртка", 709.46000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Демократической от реализация участия место обучения задания намеченных по структуры.", "Невероятный Пластиковый Стул", 618.63, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Разработке создание форм массового от на проверки массового социально-экономическое определения.", "Потрясающий Натуральный Клатч", 379.99000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Сознания проблем развития материально-технической отношении создаёт обществом позиции.", "Интеллектуальный Деревянный Плащ", 706.66999999999996, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Новая современного рост принимаемых определения качественно высшего соответствующей.", "Свободный Меховой Ботинок", 403.57999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Особенности занимаемых прогресса кругу степени рост задания для организационной.", "Интеллектуальный Пластиковый Берет", 400.56999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Укрепления различных зависит качественно разнообразный порядка.", "Свободный Бетонный Стол", 631.52999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Профессионального обуславливает проект существующий организации.", "Лоснящийся Деревянный Плащ", 745.22000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Важные задача реализация национальный уточнения.", "Грубый Кожанный Носки", 490.06999999999999, "Рекомендуемый" });
        }
    }
}
