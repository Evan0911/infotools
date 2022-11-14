<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Client extends Model
{
    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */

    //on donne les champs de la base de données qui sont modifiables
    protected $fillable = [
        'nomCli', 'prenomCli', 'adresseCli', 'cpCli', 'villeCli', 'mailCli', 'telCli'
    ];
}
