
<div class="row">
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Date:</strong>
            <input id="dateRdv" type="date" name="dateRdv">
            <input id='time' type="time" name="time">
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Client:</strong>
            <select name='idCli'>
                <option>Choisissez un client</option>
                <?php $__currentLoopData = $clients; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $client): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
                <option value='<?php echo e($client->id); ?>'><?php echo e($client->nomCli); ?> <?php echo e($client->prenomCli); ?></option>
                <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
            </select>
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12">
        <div class="form-group">
            <strong>Prospect:</strong>
            <select name='idPro'>
                <option>Choisissez un prospect</option>
                <?php $__currentLoopData = $pros; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $pro): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
                <option value='<?php echo e($pro->id); ?>'><?php echo e($pro->nomPros); ?> <?php echo e($pro->prenomPros); ?></option>
                <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
            </select>
        </div>
    </div>
    <div class="col-xs-12 col-sm-12 col-md-12 text-center">
        <button type="submit" class="btn btn-primary">Submit</button>
    </div>
</div>
<?php /**PATH C:\Users\alexa\source\repos\InfoTool2\resources\views/rdvs/form.blade.php ENDPATH**/ ?>