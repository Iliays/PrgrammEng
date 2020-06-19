<?php include ROOT . '/views/layouts/header.php'; ?>

<section>
    <div class="container">
        <div class="row">

            <h2>Кабинет пользователя</h2>

            <h3>Привет, <?php echo $user['name'];?>!</h3>
            <ul>
                <h3><li><a href="/cabinet/edit">Редактировать данные</a></li></h3>
                <?php if ($user['role'] == 'admin'): ?>
                    <h3><li><a href="/admin/">Админ. панель</a></li></h3>

                <?php endif; ?>
            </ul>

        </div>
    </div>
</section>

<?php include ROOT . '/views/layouts/footer.php'; ?>