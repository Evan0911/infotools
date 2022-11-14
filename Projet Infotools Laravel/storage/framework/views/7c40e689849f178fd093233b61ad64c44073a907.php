<!DOCTYPE html>
<html>
<head>
	<title>InfoTools</title>
	<link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.css" rel="stylesheet">
	<div class="pull-left">
		<a class="btn btn-success" href="<?php echo e(route('clients.index')); ?>">Clients</a>
		<a class="btn btn-success" href="<?php echo e(route('produits.index')); ?>">Produits</a>
		<!--<a class="btn btn-success" href="<?php echo e(route('commandes.index')); ?>">Commandes</a>-->
	</div>
	<div class="text-right">
	<?php if(auth()->guard()->guest()): ?>
            <a class="btn btn-success" href="<?php echo e(route('login')); ?>"><?php echo e(__('Login')); ?></a>
        <?php if(Route::has('register')): ?>
            <a class="btn btn-success" href="<?php echo e(route('register')); ?>"><?php echo e(__('Register')); ?></a>
        <?php endif; ?>
        <?php else: ?>
                <a class="dropdown-item" href="<?php echo e(route('logout')); ?>"
                    onclick="event.preventDefault();
                        document.getElementById('logout-form').submit();">
                            <?php echo e(__('Logout')); ?>

                </a>

                <form id="logout-form" action="<?php echo e(route('logout')); ?>" method="POST" style="display: none;">
                <?php echo csrf_field(); ?>
            	</form>
        <?php endif; ?>
	</div>
	
</head>
<body>

<div class="container">
    <?php echo $__env->yieldContent('content'); ?>
</div>

</body>
</html><?php /**PATH C:\Users\alexa\source\repos\InfoTool2\resources\views/layout.blade.php ENDPATH**/ ?>